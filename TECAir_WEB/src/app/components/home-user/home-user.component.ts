import { Component, OnInit } from '@angular/core';
import { OwlOptions } from 'ngx-owl-carousel-o';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { PromotionBooking } from 'src/app/model/promotion-booking';
import { SearchflightsService } from 'src/app/service/searchflights.service';
import { PromotionService } from 'src/app/service/promotion.service';
import { PromotionsData } from 'src/app/interface/promotions-data'
import { Router } from '@angular/router';

@Component({
  selector: 'app-home-user',
  templateUrl: './home-user.component.html',
  styleUrls: ['./home-user.component.css'],

}) 
export class HomeUserComponent implements OnInit {

  newPromotionBooking:PromotionBooking = new PromotionBooking

  promotionsdata = new Array<PromotionsData>(8)
  

  closeResult = '';

  constructor(private modalService: NgbModal, private service:SearchflightsService,private service1:PromotionService, private router:Router) { }

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
    this.service1.getRandomPromotions().subscribe(promotions=> (this.promotionsdata = promotions));
  }

    /** 
   * Este metodo permite realizar el set de los valores para el objeto que se
   * enviara con el numero de vuelo para realizar la reserva
   * @param newPromotionBooking es el objeto que almacenara el numero de vuelo a reservar
   * @param data posee los datos del vuelo que se desea reservar 
   */
    createPromotionBooking(newPromotionBooking:PromotionBooking, data:any){
    newPromotionBooking.no_promocion= data
    this.service.newPromotionBooking(newPromotionBooking);
  }


}
