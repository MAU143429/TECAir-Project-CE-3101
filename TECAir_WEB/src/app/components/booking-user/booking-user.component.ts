import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BookingData } from 'src/app/interface/booking-data';
import { TicketData } from 'src/app/interface/ticket-data';
import { BookingsService } from 'src/app/service/bookings.service';
import { ConnectionService } from 'src/app/service/connection-service';
import { ReservationDetails } from 'src/app/model/reservation-details';

@Component({
  selector: 'app-booking-user',
  templateUrl: './booking-user.component.html',
  styleUrls: ['./booking-user.component.css']
})
export class BookingUserComponent implements OnInit {

  bookingdata:BookingData[] | undefined;
  ticketsdata: TicketData[]| undefined;
  temp:any;
  

  constructor(private service:BookingsService,private connectionService:ConnectionService,private router:Router) { }

  ngOnInit(): void {
    this.service.getBookings().subscribe( booking => (this.bookingdata = booking));
    this.service.getTickets().subscribe( tickets => (this.ticketsdata = tickets));
  }



   /** 
   * Este metodo permite realizar el set de los valores para el objeto que se
   * enviara con el numero de vuelo para realizar la reserva
   * @param newBooking es el objeto que almacenara el numero de vuelo a reservar
   * @param data posee los datos del vuelo que se desea reservar 
   */
    createBilling(data:any){
      this.connectionService.sendClickEvent(parseInt(data.no_vuelo),parseInt(data.no_reservacion));
    }

    /** 
   * Este metodo permite realizar el set de los valores para el objeto que se
   * enviara con el numero de vuelo para realizar la reserva
   * @param newBooking es el objeto que almacenara el numero de vuelo a reservar
   * @param data posee los datos del vuelo que se desea reservar 
   */
     paymentDetails(data:any){
      this.connectionService.sendClickEvent2(parseInt(data.no_vuelo),parseInt(data.no_transaccion));
    }

}
 