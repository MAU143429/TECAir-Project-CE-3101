import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BookingData } from 'src/app/interface/booking-data';
import { BookingsService } from 'src/app/service/bookings.service';

@Component({
  selector: 'app-booking-user',
  templateUrl: './booking-user.component.html',
  styleUrls: ['./booking-user.component.css']
})
export class BookingUserComponent implements OnInit {

  bookingdata:BookingData[] | undefined;

  ticketsdata = [
    {
      "no_vuelo" : "XMF-675",
      "no_transaccion" : "#19834783",
      "fecha": "22/04/2022",
      "h_salida": "1:50 PM",
    },
    {
      "no_vuelo" : "MGFR-737",
      "no_transaccion" : "#24545767",
      "fecha": "19/04/2022",
      "h_salida": "2:00 AM",
    } 
]

  constructor(private service:BookingsService, private router:Router) { }

  ngOnInit(): void {
    this.service.getBookings().subscribe( booking => (this.bookingdata = booking));
  }

}
 