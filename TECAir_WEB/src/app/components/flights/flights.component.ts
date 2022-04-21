import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { Flight } from 'src/app/model/flight';
import { OpenFlight } from 'src/app/model/open-flight';
import { CloseFlight } from 'src/app/model/close-flight';
import { FlightsService } from 'src/app/service/flights.service';
import { Airport } from 'src/app/interface/airport';
import { SearchflightsService } from 'src/app/service/searchflights.service';
import { startWith, debounceTime, distinctUntilChanged, switchMap, map } from 'rxjs/operators';
import {FormControl} from '@angular/forms';
import { Models } from 'src/app/interface/models';

@Component({
  selector: 'app-flights',
  templateUrl: './flights.component.html',
  styleUrls: ['./flights.component.css']
})
export class FlightsComponent implements OnInit {


  /**
   * Creacion de variables a utilizar tanto para almacenar datos de recomendacion como de consulta
   */
  
  options = [];
  options2 = [];
  closeResult = '';
  filteredOptions: any;
  filteredOptions2: any;
  btnstatus = "Confirmar Abordaje"
  myControl = new FormControl();
  myControlModel = new FormControl();
  Models: Models[] | undefined;
  Airports: Airport[] | undefined;
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

  /**
   * Constructor de la clase Flights
   * @param modalService Permite modelar un service que nos servira de POP UP
   * @param service Permite crear una instancia del FlightsService
   * @param service2 Permite crear una instancia del SearchflightsService
   * @param router Nos ayuda a realizar parte de las consultas
   */
  constructor(private modalService: NgbModal, private service:FlightsService, private service2:SearchflightsService, private router:Router) {

    // Nos permite filtrar informacion de aeropuertos
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      debounceTime(400),
      distinctUntilChanged(),
      switchMap(val => {
            return this.filter(val || '')
       }) 
    )

    // Nos permite filtrar informacion de los modelos de avions
    this.filteredOptions2 = this.myControlModel.valueChanges.pipe(
      startWith(''),
      debounceTime(400),
      distinctUntilChanged(), 
      switchMap(val => {
            return this.filter2(val || '')
       }) 
    )

   }

  /**
  * Este metodo nos permite realizar las recomendaciones de Aeropuerto en base a lo escrito por parte usuario y lo que se consulta con el GET al API
  * @param val El valor ingresado en el input por el usuario
  * @returns Las recomendaciones que mas se acercan a lo escrito por el user 
  */
  filter(val: string): any {

  return this.service2.getAirports()
    .pipe(
      map(response => response.filter(option => { 
        return option.ciudad.toLowerCase().indexOf(val.toLowerCase()) === 0 
        || option.pais.toLowerCase().indexOf(val.toLowerCase()) === 0 
        || option.nombre.toLowerCase().indexOf(val.toLowerCase()) === 0
      }))
    )
  }  

  /**
  * Este metodo nos permite realizar las recomendaciones de Modelos de Avion en base a lo escrito por parte usuario y lo que se consulta con el GET al API
  * @param val El valor ingresado en el input por el usuario
  * @returns Las recomendaciones que mas se acercan a lo escrito por el user 
  */
  filter2(val: string): any {

  return this.service2.getModels()
    .pipe(
      map(response => response.filter(option => { 
        return option.av_nombre.toLowerCase().indexOf(val.toLowerCase()) === 0 
      }))
    )
  }  

  /**
   *  Este metodo permite hacer el display de un template en este caso el POP UP
   * @param content el template a mostrar
   */
  open(content:any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
  
  /**
   * Metodo que permite crear las acciones del boton exit del popup
   * @param reason 
   * @returns 
   */
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

    // Consulta de valores al API
    this.service2.getAirports().subscribe( data => (this.Airports = data));
    this.service2.getModels().subscribe( data2 => (this.Models = data2));

    // Cambia el valor del boton en base al status del pasajero en el vuelo
    if ( this.passangerdata[0].abordaje == "No") {
      this.btnstatus = "Confirmar abordaje"
    }else {
      this.btnstatus = "Cancelar abordaje";
    }
  }

  /**
   * Este metodo permite llamar al post con la informacion necesaria para registrar un vuelo
   * @param newFlight Los datos del vuelo a registrar
   */
  addNewFlight(newFlight:Flight){
    this.service.addFlight(newFlight).subscribe(flight=> console.log(flight));
  }

  /**
   * Permite enviar la solicitud para chequear si un pasajero ya fue 
   * aprobado de abordar o por el contrario no a confirmado aun
   * @param newOpenFlight Datos para consulta de un vuelo abierto
   */
  newAddOpenFlight(newOpenFlight:OpenFlight){
    this.service.newOpen(newOpenFlight).subscribe(open=> console.log(open));
  }

  /**
   * Este metodo realiza la consulta de si un vuelo esta listo para 
   * ser cerrado
   * @param newCloseFlight Datos para consulta de un vuelo cerrado
   */
  newAddCloseFlight(newCloseFlight:CloseFlight){
  this.service.newClose(newCloseFlight).subscribe(close=> console.log(close));
  }

  

}
 