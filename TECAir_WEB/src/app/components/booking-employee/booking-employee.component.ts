import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BookingData } from 'src/app/interface/booking-data';
import { BookingsService } from 'src/app/service/bookings.service';
import { TicketData } from 'src/app/interface/ticket-data';

@Component({
  selector: 'app-booking-employee',
  templateUrl: './booking-employee.component.html',
  styleUrls: ['./booking-employee.component.css']
})
export class BookingEmployeeComponent implements OnInit {

  bookingdata:BookingData[] | undefined;

  ticketsdata: TicketData[]| undefined;

  constructor(private service:BookingsService, private router:Router) { }

  ngOnInit(): void {
    this.service.getBookings().subscribe( booking => (this.bookingdata = booking));
    this.service.getTickets().subscribe( tickets => (this.ticketsdata = tickets));
  }

}
