import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BookingData } from 'src/app/interface/booking-data';
import { BookingsService } from 'src/app/service/bookings.service';
import { TicketData } from 'src/app/interface/ticket-data';
import { ConnectionService } from 'src/app/service/connection-service';

@Component({
  selector: 'app-booking-employee',
  templateUrl: './booking-employee.component.html',
  styleUrls: ['./booking-employee.component.css']
})
export class BookingEmployeeComponent implements OnInit {

  bookingdata:BookingData[] | undefined;
  ticketsdata: TicketData[]| undefined;

  constructor(private service:BookingsService, private connectionService:ConnectionService,private router:Router) { }

  ngOnInit(): void {
    this.service.getBookings().subscribe( booking => (this.bookingdata = booking));
    this.service.getTickets().subscribe( tickets => (this.ticketsdata = tickets));
  }

   /** 
   * Este metodo permite realizar el set de los valores de la reservacion para que el 
   * usuario pueda realizar el pago de su reserva.
   * @param data posee los datos del vuelo pagar
   */
    createBilling(data:any){
      this.connectionService.sendClickEvent(parseInt(data.no_vuelo),parseInt(data.no_reservacion));
    }

  /** 
   * Este metodo permite realizar el set de los valores del tiquete para que se genere el comprobante de pago
   * @param data posee los datos del tiquete a facturar
   */
     paymentDetails(data:any){
      this.connectionService.sendClickEvent2(parseInt(data.no_vuelo),parseInt(data.no_transaccion));
    }

}
