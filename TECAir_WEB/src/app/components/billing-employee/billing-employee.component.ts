import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-billing-employee',
  templateUrl: './billing-employee.component.html',
  styleUrls: ['./billing-employee.component.css']
})
export class BillingEmployeeComponent implements OnInit {

  reservationdata= [
    {
      "no_vuelo" : "#9999999",
      "origen" : "Aeropuerto Internacional Juan Santamaria",
      "destino": "Aeropuerto Benito Juarez",
      "ciudad_origen" : "San Jose",
      "ciudad_destino" :"Ciudad de Mexico",
      "avion": "Airbus 737",
      "ptr_abordaje" : "G31",
      "fecha": "22/04/2022",
      "h_salida": "1:50 PM",
      "h_llegada": "10:50 PM",
      "duracion" : "8 h 31 mins",
      "cant_escalas" : "2"
    },

]

  constructor() { }

  ngOnInit(): void {
  }

}
