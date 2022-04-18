import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { Search } from 'src/app/model/search';
import { Searchresults } from 'src/app/interface/searchresults';
import { Airport } from 'src/app/interface/airport';
import { SearchflightsService } from 'src/app/service/searchflights.service';
import { startWith, debounceTime, distinctUntilChanged, switchMap, map } from 'rxjs/operators';
import {FormControl} from '@angular/forms';


@Component({
  selector: 'app-search-user',
  templateUrl: './search-user.component.html', 
  styleUrls: ['./search-user.component.css']
})
export class SearchUserComponent implements OnInit {

  newSearch:Search = new Search
  Airports: Airport[] | undefined;
  searchdata:Searchresults[] | undefined;

  myControl = new FormControl();
  options = [];
  filteredOptions: any;

  closeResult = '';

  constructor(private modalService: NgbModal , private service:SearchflightsService, private router:Router) { 
    
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      debounceTime(400),
      distinctUntilChanged(),
      switchMap(val => {
            return this.filter(val || '')
       }) 
    )

  }

  filter(val: string): any {
 
    return this.service.getAirports()
     .pipe(
       map(response => response.filter(option => { 
         return option.ciudad.toLowerCase().indexOf(val.toLowerCase()) === 0 
         || option.pais.toLowerCase().indexOf(val.toLowerCase()) === 0 
         || option.nombre.toLowerCase().indexOf(val.toLowerCase()) === 0
       }))
     )
   }  

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
    this.service.getAirports().subscribe( data => (this.Airports = data));

  } 
  
  // Metodo para crear una nueva busqueda de vuelos
  createNewSearch(newSearch:Search){
    this.service.getSearch(newSearch).subscribe(search=> (this.searchdata = search));
  }
}
