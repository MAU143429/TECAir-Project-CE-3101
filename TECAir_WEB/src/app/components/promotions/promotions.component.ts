import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { Router } from '@angular/router';
import { Promotion } from 'src/app/model/promotion';
import { PromotionBooking } from 'src/app/model/promotion-booking';
import { PromotionService } from 'src/app/service/promotion.service';
import { SearchflightsService } from 'src/app/service/searchflights.service';
import { PromotionsData } from 'src/app/interface/promotions-data'



@Component({ 
  selector: 'app-promotions',
  templateUrl: './promotions.component.html',
  styleUrls: ['./promotions.component.css']
})
export class PromotionsComponent implements OnInit {

  newPromotion:Promotion = new Promotion
  newPromotionBooking:PromotionBooking = new PromotionBooking
  promotionsdata = new Array<PromotionsData>(8)

  
  closeResult = '';

  constructor(private modalService: NgbModal, private service:PromotionService,private service2:SearchflightsService, private router:Router) { }

  open(content:any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
  
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return  `with: ${reason}`;
    }
  }

  customOptions: OwlOptions = {
    loop: true,
    margin: 20,
    mouseDrag: true,
    touchDrag: true,
    pullDrag: true,
    autoplaySpeed:1000,
    autoplay:true,
    dots: true,
    navSpeed: 700,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1
      },
      400: {
        items: 2
      },
      740: {
        items: 3
      },
      940: {
        items: 4
      }
    },
    nav: true
  }

  ngOnInit(): void {
    this.service.getRandomPromotions().subscribe(promotions=> (this.promotionsdata = promotions));
  }

  /**
   * Metodo que permite comunicar al API una nueva solicitud para creacion de una promocion.
   * @param newPromotion Ingresa el objeto con los valores de la nueva promocion a crear
   */
  addNewPromotion(newPromotion:Promotion){
    this.service.addPromotion(newPromotion).subscribe(promotion=> console.log(promotion));
  }


   /** 
   * Este metodo permite realizar el set de los valores para el objeto que se
   * enviara con el numero de vuelo para realizar la reserva
   * @param newBooking es el objeto que almacenara el numero de vuelo a reservar
   * @param data posee los datos del vuelo que se desea reservar 
   */
    createPromotionBooking(newPromotionBooking:PromotionBooking, data:any){
      newPromotionBooking.no_promocion= data
      this.service2.newPromotionBooking(newPromotionBooking);
    }

} 
