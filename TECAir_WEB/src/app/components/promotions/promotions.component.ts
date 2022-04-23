import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { Router } from '@angular/router';
import { Promotion } from 'src/app/model/promotion';
import { PromotionBooking } from 'src/app/model/promotion-booking';
import { PromotionService } from 'src/app/service/promotion.service';
import { SearchflightsService } from 'src/app/service/searchflights.service';



@Component({ 
  selector: 'app-promotions',
  templateUrl: './promotions.component.html',
  styleUrls: ['./promotions.component.css']
})
export class PromotionsComponent implements OnInit {

  newPromotion:Promotion = new Promotion
  newPromotionBooking:PromotionBooking = new PromotionBooking

  promotionsdata = [
    
    {
      "no_vuelo" : "#99999999",
      "no_promocion" : "1",
      "url" : "https://images.costarica.org/wp-content/uploads/2017/04/Caribbean-Coast-View2.jpg",
      "lugares" : "San Jose - Medellin",
      "fecha" : "19-04-2022",
      "porcentaje": "30",
      "precio": "350",
    },
    {
      "no_vuelo" : "#99999999",
      "no_promocion" : "2",
      "url" : "https://media.tacdn.com/media/attractions-content--1x-1/0b/2b/fc/2a.jpg",
      "lugares" : "San Jose - Rio de Janeiro",
      "fecha" : "30-05-2022",
      "porcentaje": "10",
      "precio": "700",
    }, 
    {
      "no_vuelo" : "#99999999",
      "no_promocion" : "3",
      "url" : "https://cdn2.civitatis.com/egipto/el-cairo/el-cairo.jpg",
      "lugares" : "San Jose - El Cairo",
      "fecha" : "25-04-2022",
      "porcentaje": "20",
      "precio": "1250",
    },
  
    {
      "no_vuelo" : "#99999999",
      "no_promocion" : "4",
      "url" : "https://www.viajarlosangeles.com/img/guia-viajar-los-angeles.jpg",
      "lugares" : "San Jose - Los Angeles",
      "fecha" : "18-06-2022",
      "porcentaje": "10",
      "precio": "800",
    },
    {
      "no_vuelo" : "#99999999",
      "no_promocion" : "5",
      "url" : "https://dam.ngenespanol.com/wp-content/uploads/2021/05/cuanto-cuesta-viajar-a-nueva-york.jpg",
      "lugares" : "Sao Paulo - New York",
      "fecha" : "24-05-2022",
      "porcentaje": "40",
      "precio": "1000",
    },
    {
      "no_vuelo" : "#99999999",
      "no_promocion" : "6",
      "url" : "https://cdn2.civitatis.com/republica-checa/praga/guia/praga.jpg",
      "lugares" : "Madrid - Praga",
      "fecha" : "22-04-2022",
      "porcentaje": "25",
      "precio": "900",
    },
    {
      "no_vuelo" : "#99999999",
      "no_promocion" : "7",
      "url" : "https://cdn2.civitatis.com/estados-unidos/las-vegas/las-vegas.jpg",
      "lugares" : "Londres - Las Vegas",
      "fecha" : "02-05-2022",
      "porcentaje": "15",
      "precio": "1200",
    },
    {
      "no_vuelo" : "#99999999",
      "no_promocion" : "8",
      "url" : "https://pymstatic.com/97927/conversions/psicologos-lisboa-default.jpg",
      "lugares" : "Bruselas - Lisboa",
      "fecha" : "14-07-2022",
      "porcentaje": "50",
      "precio": "250",
    }
  ]
  
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
