import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { Search } from 'src/app/model/search';
import { SearchflightsService } from 'src/app/service/searchflights.service';

@Component({
  selector: 'app-search-employee',
  templateUrl: './search-employee.component.html',
  styleUrls: ['./search-employee.component.css']
})
export class SearchEmployeeComponent implements OnInit {

  newSearch:Search = new Search

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

  constructor(private modalService: NgbModal , private service:SearchflightsService, private router:Router) { }

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

  // Metodo para crear una nueva busqueda de vuelos
  createNewSearch(newSearch:Search){
    this.service.newSearch(newSearch).subscribe(search=> console.log(search));
  }
  
}
