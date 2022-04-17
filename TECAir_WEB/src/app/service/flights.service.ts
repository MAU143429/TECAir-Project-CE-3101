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
   */
    addFlight(flight:any):Observable<any>{
      return this.httpclient.post(this.url+'/Vuelo/Add', flight) 
    }

    /** POST PARA CONSULTA APERTURA DE VUELO
   *  Este post permite enviar la informacion para consultar un apertura de vuelo por usuario.
   */
     newOpen(openFlight:any):Observable<any>{
      return this.httpclient.post(this.url+'/VueloAbierto', openFlight) 
    }

    /** POST PARA CONSULTA CIERRE DE VUELO
   *  Este post permite enviar la informacion para el cierre de un vuelo.
   */
     newClose(closeFlight:any):Observable<any>{
      return this.httpclient.post(this.url+'/VueloCerrado', closeFlight) 
    }

}
 