import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { Flight } from 'src/app/model/flight';
import { OpenFlight } from 'src/app/model/open-flight';
import { CloseFlight } from 'src/app/model/close-flight';
import { FlightsService } from 'src/app/service/flights.service';


@Component({
  selector: 'app-flights',
  templateUrl: './flights.component.html',
  styleUrls: ['./flights.component.css']
})
export class FlightsComponent implements OnInit {

  newFlight:Flight = new Flight
  newOpenFlight:OpenFlight = new OpenFlight
  newCloseFlight:CloseFlight = new CloseFlight


  passangerdata = [
    {
      "no_vuelo" : "XMF-675",
      "p_nombre" : "Juan Santamaria",
      "origen" : "San Jose, Costa Rica",
      "destino": "Ciudad de Mexico, Mexico",
      "abordaje": "Si",
    }
  ]

    flightdata = [
    {
      "no_vuelo" : "MGFR-737",
      "origen" : "San Jose, Costa Rica",
      "destino": "Ciudad de Mexico, Mexico",
      "h_salida": "2:00 AM",
    }
  ]

  btnstatus = "Confirmar Abordaje"
  closeResult = '';
  constructor(private modalService: NgbModal, private service:FlightsService, private router:Router) { }

  open(content:any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
  
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return  `with: ${reason}`;
    }
  }
 
  ngOnInit(): void { 
    if ( this.passangerdata[0].abordaje == "No") {
      this.btnstatus = "Confirmar abordaje"
    }else {
      this.btnstatus = "Cancelar abordaje";
    }
  }

  // Metodo para agregar un nuevo vuelo
  addNewFlight(newFlight:Flight){
    this.service.addFlight(newFlight).subscribe(flight=> console.log(flight));
  }

  // Metodo para consultar la apertura de un vuelo
  newAddOpenFlight(newOpenFlight:OpenFlight){
    this.service.addFlight(newOpenFlight).subscribe(open=> console.log(open));
  }

    // Metodo para consultar el cierre de un vuelo
    newAddCloseFlight(newCloseFlight:CloseFlight){
    this.service.addFlight(newCloseFlight).subscribe(close=> console.log(close));
  }

  

}
 