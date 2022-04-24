import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Baggage } from 'src/app/model/baggage';
import { CheckIn } from 'src/app/model/check-in';
import { CheckData } from 'src/app/interface/check-data';
import { BaggageService } from 'src/app/service/baggage.service';

@Component({
  selector: 'app-baggage',
  templateUrl: './baggage.component.html',
  styleUrls: ['./baggage.component.css']
})
export class BaggageComponent implements OnInit {

  newBaggage:Baggage = new Baggage
  newCheckin:CheckIn = new CheckIn
  checkdata: CheckData[] | undefined; 


  constructor(private service:BaggageService, private router:Router) { }
 
  ngOnInit(): void {}

  /**
   * Metodo que permite crear una nueva maleta
   * @param newBaggage Objeto que contiene toda la informacion para registrar una maleta
   */
  addNewBaggage(newBaggage:Baggage){
    this.service.addBaggage(newBaggage).subscribe(baggage=> console.log(baggage));
  }

  /**
   * Este metodo permite verificar si un pasajero ya fue chequeado.
   * @param newCheckin Objeto que contiene la informacion de un pasajero para que este pueda ser chequeado
   */
  addNewCheckIn(data:any){
    this.newCheckin = data.no_transaccion
    this.service.getCheckData(this.newCheckin).subscribe(checkin=> (this.checkdata = checkin));
    
  }

}
