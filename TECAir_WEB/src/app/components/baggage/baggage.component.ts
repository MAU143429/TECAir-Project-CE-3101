import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Baggage } from 'src/app/model/baggage';
import { CheckIn } from 'src/app/model/check-in';
import { BaggageService } from 'src/app/service/baggage.service';

@Component({
  selector: 'app-baggage',
  templateUrl: './baggage.component.html',
  styleUrls: ['./baggage.component.css']
})
export class BaggageComponent implements OnInit {

  newBaggage:Baggage = new Baggage
  newCheckin:CheckIn = new CheckIn


  checkdata = [
    {
      "no_transaccion" : "XMF-675",
      "no_vuelo" : "XMF-675",
      "p_nombre" : "Juan Perez Chaverri",
      "h_salida": "1:00 PM",
    }
]

  constructor(private service:BaggageService, private router:Router) { }
 
  ngOnInit(): void {}

  // Metodo para agregar una nueva maleta
  addNewBaggage(newBaggage:Baggage){
    this.service.addBaggage(newBaggage).subscribe(baggage=> console.log(baggage));
  }

  // Metodo para agregar un nuevo usuario desde la seccion de registro
  addNewCheckIn(newCheckin:CheckIn){
    this.service.newCheckin(newCheckin).subscribe(checkin=> console.log(checkin));
  }

}
