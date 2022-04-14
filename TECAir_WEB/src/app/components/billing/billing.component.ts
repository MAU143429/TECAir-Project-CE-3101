import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'app-billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent implements OnInit {

  closeResult = '';

  passangerdata = [
    {
      "no_vuelo" : "XMF-675",
      "p_nombre" : "Juan Santamaria",
      "origen" : "SJO Costa Rica Aeropuerto Internacional Juan Santamaria",
      "destino": "MXN Mexico Aeropuerto Benito Juarez",
      "abordaje": "No",
    }
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
