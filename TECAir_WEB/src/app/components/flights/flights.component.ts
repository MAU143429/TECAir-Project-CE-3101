import { Component, OnInit } from '@angular/core';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'app-flights',
  templateUrl: './flights.component.html',
  styleUrls: ['./flights.component.css']
})
export class FlightsComponent implements OnInit {

  passangerdata = [
    {
      "no_vuelo" : "XMF-675",
      "p_nombre" : "Juan Santamaria",
      "origen" : "SJO Costa Rica Aeropuerto Internacional Juan Santamaria",
      "destino": "MXN Mexico Aeropuerto Benito Juarez",
      "abordaje": "No",
    }
]

    flightdata = [
    {
      "no_vuelo" : "MGFR-737",
      "origen" : "SJO Costa Rica Aeropuerto Internacional Juan Santamaria",
      "destino": "MXN Mexico Aeropuerto Benito Juarez",
      "h_salida": "2:00 AM",
    }
]



  
  time: any;
  takeoff: NgbDateStruct | undefined;
  closeResult = '';

  constructor(private modalService: NgbModal) { }

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
  }

}
 