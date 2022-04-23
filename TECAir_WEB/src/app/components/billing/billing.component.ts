import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { TicketPayment } from 'src/app/model/ticket-payment';
import { ReservationData } from 'src/app/interface/reservation-data'
import { BookingsService } from 'src/app/service/bookings.service';


@Component({
  selector: 'app-billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent implements OnInit {

  newTicketPayment:TicketPayment = new TicketPayment
  reservationdata:ReservationData[] | any;
  closeResult = ''; 

constructor(private service:BookingsService, private router:Router) { }



  ngOnInit(): void {
  }

  // Metodo para agregar un nuevo tiquete luego de que este fuera cancelado.
  addNewTicketPayment(newTicketPayment:TicketPayment){
    this.service.addTicketPayment(newTicketPayment).subscribe(ticket=> console.log(ticket));
  }

}
