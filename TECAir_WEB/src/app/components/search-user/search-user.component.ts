import { Component, OnInit } from '@angular/core';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';



@Component({
  selector: 'app-search-user',
  templateUrl: './search-user.component.html', 
  styleUrls: ['./search-user.component.css']
})
export class SearchUserComponent implements OnInit {

  searchdata= [
    {
      "no_vuelo" : "XMF-675",
      "origen" : "SJO Costa Rica Aeropuerto Internacional Juan Santamaria",
      "destino": "MXN Mexico Aeropuerto Benito Juarez",
      "cant_escalas": "3",
      "fecha": "22/04/2022",
      "h_salida": "1:50 PM",
      "h_llegada": "10:00 PM",
      "precio": "$350"
    },
]

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
