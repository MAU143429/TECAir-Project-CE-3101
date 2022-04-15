import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'app-billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent implements OnInit {

  closeResult = '';

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
