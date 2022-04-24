import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Flight } from '../model/flight';
import { OpenFlight } from '../model/open-flight';
import { CloseFlight } from '../model/close-flight';


@Injectable({
  providedIn: 'root'
})
export class FlightsService {

  url = 'https://localhost:7038/api'

  constructor(private httpclient:HttpClient) { }

   /** POST PARA CREAR VUELO
   *  Este post permite enviar la informacion para registrar un vuelo nuevo.
   * @param flight ingresa un objeto de tipo vuelo con la informacion necesaria para el registro.
   * @returns Retorna la aprobacion del post, si fue guardado con exito
   */
    addFlight(flight:any):Observable<any>{
      console.log(flight)
      return this.httpclient.post(this.url+'/VueloWEB/Add', flight) 
    }

    /** POST PARA CREAR ESCALAS EN VUELOS
   *  Este post permite enviar la informacion para registrar una nueva escala.
   * @param flight ingresa un objeto de tipo vuelo con la informacion necesaria para el registro.
   * @returns Retorna la aprobacion del post, si fue guardado con exito
   */
     addScale(scale:any):Observable<any>{
      return this.httpclient.post(this.url+'/Escala/Add', scale) 
    }

    /** GET PARA CONSULTA APERTURA DE VUELO
    *  Este get permite enviar la informacion para consultar un apertura de vuelo por usuario.
    */
     newOpen(openFlight:any):Observable<any>{
      return this.httpclient.get(this.url+'/VueloAbierto/Get/' + openFlight.no_transaccion) 
    }


    /** PUT  APERTURA DE VUELO
    *  Este put permite modificar el valor del booleano que indica si el pasajero abordara.
    */
     updateOpen(updateFlight:any):Observable<any>{
      console.log(updateFlight)
      return this.httpclient.put(this.url+'/VueloAbierto/updateAbordaje', updateFlight) 
    }


    /** GET PARA CONSULTA CIERRE DE VUELO
    *  Este post permite enviar la informacion para el cierre de un vuelo.
    */
     newClose(closeFlight:any):Observable<any>{
      return this.httpclient.get(this.url+'/VueloCerrado/Get/' +  closeFlight.no_vuelo) 
    }

    /** POST PARA CONSULTA APERTURA DE VUELO
    *  Este post permite enviar la informacion para consultar un apertura de vuelo por usuario.
    */
     getBaggageReport(info:any):Observable<any>{
      return this.httpclient.get(this.url+'/VueloWEB/GetMaletas/' + info.no_vuelo) 
    }

}
 