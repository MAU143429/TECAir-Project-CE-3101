import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { Flight } from 'src/app/model/flight';
import { OpenFlight } from 'src/app/model/open-flight';
import { CloseFlight } from 'src/app/model/close-flight';
import { UpdateFlight } from 'src/app/model/update-flight';
import { Scale } from 'src/app/model/scale';
import { FlightsService } from 'src/app/service/flights.service';
import { SearchflightsService } from 'src/app/service/searchflights.service';
import { startWith, debounceTime, distinctUntilChanged, switchMap, map } from 'rxjs/operators';
import { Passangerdata } from 'src/app/interface/passangerdata';
import { Flightdata } from 'src/app/interface/flightdata';
import {FormControl} from '@angular/forms';
import { ConnectionService } from 'src/app/service/connection-service';

@Component({
  selector: 'app-flights',
  templateUrl: './flights.component.html',
  styleUrls: ['./flights.component.css']
})
export class FlightsComponent implements OnInit {


  /**
   * Creacion de variables a utilizar tanto para almacenar datos de recomendacion como de consulta
   */
  

  closeResult = '';
  filteredOptions: any;
  filtered2: any;
  btnstatus = "Confirmar Abordaje"
  myControl = new FormControl();
  myControlModel = new FormControl();
  passangerdata:Passangerdata[] | undefined;
  flightdata:Flightdata[] | undefined;
  newFlight:Flight = new Flight
  newOpenFlight:OpenFlight = new OpenFlight
  newCloseFlight:CloseFlight = new CloseFlight
  newUpdateFlight:UpdateFlight = new UpdateFlight
  scale1:Scale = new Scale
  scale2:Scale = new Scale
  scale3:Scale = new Scale

  

  /**
   * Constructor de la clase Flights
   * @param modalService Permite modelar un service que nos servira de POP UP
   * @param service Permite crear una instancia del FlightsService
   * @param service2 Permite crear una instancia del SearchflightsService
   * @param router Nos ayuda a realizar parte de las consultas
   */
  constructor(private modalService: NgbModal, private service:FlightsService, private service2:SearchflightsService,private connectionService:ConnectionService, private router:Router) {

    // Nos permite filtrar informacion de aeropuertos
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      debounceTime(400),
      distinctUntilChanged(),
      switchMap(val => {
            return this.filter(val || '')
       }) 
    )

    // Nos permite filtrar informacion de los modelos de aviones
    this.filtered2 = this.myControlModel.valueChanges.pipe(
      startWith(''),
      debounceTime(400),
      distinctUntilChanged(), 
      switchMap(val2 => {
            return this.filter2(val2 || '')
       }) 
    )

   }

  /**
  * Este metodo nos permite realizar las recomendaciones de Aeropuerto en base a lo escrito por parte usuario y lo que se consulta con el GET al API
  * @param val El valor ingresado en el input por el usuario
  * @returns Las recomendaciones que mas se acercan a lo escrito por el user 
  */
  filter(val: string): any {
    console.log(this.service2.getAirports())
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
  * @param val2 El valor ingresado en el input por el usuario
  * @returns Las recomendaciones que mas se acercan a lo escrito por el user 
  */
  filter2(val2: string): any {
    console.log(this.service2.getModels())
  return this.service2.getModels()
    .pipe(
      map(response2 => response2.filter(option2 => { 
        return option2.av_nombre.toLowerCase().indexOf(val2.toLowerCase()) === 0 
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
    /**
     / Cambia el valor del boton en base al status del pasajero en el vuelo
    if ( this.passangerdata[0].abordaje == "No") {
      this.btnstatus = "Confirmar abordaje"
    }else {
      this.btnstatus = "Cancelar abordaje";
    }*/
  }

  /**
   * Este metodo permite llamar al post con la informacion necesaria para registrar un vuelo
   * @param newFlight Los datos del vuelo a registrar
   */
  addNewFlight(newFlight:Flight){
    this.service.addFlight(newFlight).subscribe(flight=> console.log(flight));
    if(newFlight.escala1 != ''){
      this.scale1.escala = newFlight.escala1
      this.scale1.orden = 1
      this.service.addScale(this.scale1).subscribe(scale1=> console.log(scale1));
    }
    if(newFlight.escala2 != ''){
      this.scale1.escala = newFlight.escala2
      this.scale1.orden = 2
      this.service.addScale(this.scale2).subscribe(scale2=> console.log(scale2));
    }
    if(newFlight.escala2 != ''){
      this.scale1.escala = newFlight.escala3
      this.scale1.orden = 2
      this.service.addScale(this.scale3).subscribe(scale3=> console.log(scale3));
    }
    
  }

  /**
   * Permite enviar la solicitud para chequear si un pasajero ya fue 
   * aprobado de abordar o por el contrario no a confirmado aun
   * @param newOpenFlight Datos para consulta de un vuelo abierto 
   */
  newAddOpenFlight(newOpenFlight:OpenFlight){
    this.service.newOpen(newOpenFlight).subscribe(open=> (this.passangerdata = open));
    
  }

  /** 
   * Este metodo realiza la consulta de si un vuelo esta listo para 
   * ser cerrado
   * @param newCloseFlight Datos para consulta de un vuelo cerrado
   */
  newAddCloseFlight(newCloseFlight:CloseFlight){
  this.service.newClose(newCloseFlight).subscribe(open=> (this.flightdata = open));
  }

  /**
   * Este metodo realiza el update para el abordaje de un pasajero
   * @param newCloseFlight Datos para consulta de un vuelo cerrado
   */
   newAddUpdateFlight(newUpdateFlight:UpdateFlight, data:any){
    newUpdateFlight.no_transaccion = data.no_transaccion
    this.service.updateOpen(newUpdateFlight).subscribe(close=> console.log(close));
    }

    /** 
   * Este metodo permite enviar la descripcion del cierre del vuelo para poder generar el reporte
   * @param data posee los datos del vuelo que se desea reservar 
   */
    ReportDetails(data:any){
      this.connectionService.sendClickEvent3(parseInt(data)); 
    }
  

}
 