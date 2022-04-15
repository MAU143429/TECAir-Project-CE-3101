import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-baggage',
  templateUrl: './baggage.component.html',
  styleUrls: ['./baggage.component.css']
})
export class BaggageComponent implements OnInit {

  checkdata = [
    {
      "no_transaccion" : "XMF-675",
      "no_vuelo" : "XMF-675",
      "p_nombre" : "Juan Perez Chaverri",
      "h_salida": "1:00 PM",
    }
]

  constructor() { }

  ngOnInit(): void {
  }

}
