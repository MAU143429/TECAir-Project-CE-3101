import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { TicketPayment } from 'src/app/model/ticket-payment';
import { BookingsService } from 'src/app/service/bookings.service';
import { ReservationData } from 'src/app/interface/reservation-data'
import { ConnectionService } from 'src/app/service/connection-service';
import { ReservationDetails } from 'src/app/model/reservation-details';



@Component({
  selector: 'app-billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent implements OnInit {

  newTicketPayment:TicketPayment = new TicketPayment
  reservationdata:ReservationData[] | any;
  newReservationDetails:ReservationDetails = new ReservationDetails


  async delay(ms: number) {
    await new Promise<void>(resolve => setTimeout(()=>resolve(), ms)).then(()=>console.log("fired"));
  }

constructor(private service:BookingsService,private connectionService:ConnectionService, private router:Router) { }

  ngOnInit(): void {
      this.delay(100).then(()=>{
        this.createBilling(this.newReservationDetails,this.connectionService.getNoVueloEvent(),this.connectionService.getNoReservacionEvent())
      });
  }
    

  // Metodo para agregar un nuevo tiquete luego de que este fuera cancelado.
  addNewTicketPayment(newTicketPayment:TicketPayment){
    this.service.addTicketPayment(newTicketPayment).subscribe(ticket=> console.log(ticket));
  }


  /** 
 * Este metodo permite realizar la peticion de un detalle para una reservacion en particular
 * @param newReservationDetails es el objeto que almacenara los detalles de numero de vuelo y reserva
 * @param data1 numero de vuelo
 * @param data2 numero de reserva
 */
    createBilling(newReservationDetails:ReservationDetails, data1:any,data2:any){
      newReservationDetails.no_vuelo = data1
      newReservationDetails.no_reservacion = data2
      this.service.newBilling(newReservationDetails).subscribe(book => (this.reservationdata = book));
    }


}
