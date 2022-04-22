import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { TicketPayment } from 'src/app/model/ticket-payment';
import { BookingsService } from 'src/app/service/bookings.service';


@Component({
  selector: 'app-billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent implements OnInit {

  newTicketPayment:TicketPayment = new TicketPayment
  closeResult = ''; 

  reservationdata= [
    {
      "no_vuelo" : 9999999,
      "origen" : "Aeropuerto Internacional Juan Santamaria",
      "destino": "Aeropuerto Benito Juarez",
      "ciudad_origen" : "San Jose",
      "ciudad_destino" :"Ciudad de Mexico",
      "avion": "Airbus 737",
      "ptr_abordaje" : "G31",
      "fecha": "22/04/2022",
      "h_salida": "1:50 PM",
      "h_llegada": "10:50 PM",
      "cant_escalas" : "2",
      "no_reservacion" : 22222
    },

]

constructor(private service:BookingsService, private router:Router) { }



  ngOnInit(): void {
  }

  // Metodo para agregar un nuevo tiquete luego de que este fuera cancelado.
  addNewTicketPayment(newTicketPayment:TicketPayment){
    this.service.addTicketPayment(newTicketPayment).subscribe(ticket=> console.log(ticket));
  }

}
