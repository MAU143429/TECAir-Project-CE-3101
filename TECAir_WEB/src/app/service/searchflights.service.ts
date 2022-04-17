import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Search } from '../model/search';
import { Airport } from '../interface/airport'


@Injectable({
  providedIn: 'root'
})
export class SearchflightsService {

  url = 'https://localhost:7038/api'

  constructor(private httpclient:HttpClient) { }

  /** POST PARA REALIZAR BUSQUEDA
   *  Este post permite enviar la informacion para realizar una busqueda de un vuelo.
   */
  newSearch(search:any):Observable<any>{
    return this.httpclient.post(this.url+'/Busqueda/New', search) 
  }

  //GET
  getAirports():Observable<Airport[]>{
    //Se realiza la solicitud GET en un endpoint GetVuelos para obtener la informacion de los aeropuertos disponibles
    return this.httpclient.get<Airport[]>(this.url+'/Aeropuerto')
  }
}
 