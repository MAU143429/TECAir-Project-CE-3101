import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { Search } from 'src/app/model/search';
import { Airport } from 'src/app/interface/airport';
import { BookingFlight } from 'src/app/model/booking-flight';
import { Searchresults } from 'src/app/interface/searchresults';
import { SearchflightsService } from 'src/app/service/searchflights.service';
import { startWith, debounceTime, distinctUntilChanged, switchMap, map } from 'rxjs/operators';
import {FormControl} from '@angular/forms';



@Component({
  selector: 'app-search-employee',
  templateUrl: './search-employee.component.html',
  styleUrls: ['./search-employee.component.css']
})
export class SearchEmployeeComponent implements OnInit {

  newSearch:Search = new Search
  newBooking:BookingFlight = new BookingFlight
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

  /** 
   * Este metodo permite realizar la peticion del service que permite realizar la busqueda
   * @param newSearch es el objeto que posee los datos con las caracteristicas de busqueda
   */
   createNewSearch(newSearch:Search){
    this.service.getSearch(newSearch).subscribe(search=> (this.searchdata = search));
  }

    /** 
   * Este metodo permite realizar el set de los valores para el objeto que se
   * enviara con el numero de vuelo para realizar la reserva
   * @param newBooking es el objeto que almacenara el numero de vuelo a reservar
   * @param data posee los datos del vuelo que se desea reservar 
   */
  createBooking(newBooking:BookingFlight, data:any){
    newBooking.no_vuelo = data.no_vuelo
    this.service.newBooking(newBooking);
  }
  
}
