import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Search } from '../model/search';
import { Airport } from '../interface/airport'
import { Searchresults } from '../interface/searchresults'



@Injectable({
  providedIn: 'root'
})
export class SearchflightsService {

  url = 'https://localhost:7038/api'

  constructor(private httpclient:HttpClient) { }

  /** POST PARA REALIZAR RESERVACIONES
   *  Este post permite enviar la informacion para realizar una reservacion de un vuelo.
   * @param booking contiene el numero de vuelo que se desea reservar
   * @returns retorna la lista de reservas
   */
  newBooking(booking:any):Observable<any>{
    console.log("Haciendo el post")
    console.log(booking)
    return this.httpclient.post(this.url+'/Reservacion/Add', booking) 
  }

  /** GET DE AEROPUERTOS
   * Este metodo permite traer los aeropuertos almacenados en el API para asi recomendarlos al usuario.
   * @returns la lista de aeropuertos que se le recomiendan al usuario en pantalla
   */
  getAirports():Observable<Airport[]>{
    //Se realiza la solicitud GET en un endpoint Aeropuerto para obtener la informacion de los aeropuertos disponibles
    return this.httpclient.get<Airport[]>(this.url+'/Aeropuerto')
  }

  /** GET DE BUSQUEDA
  * Este metodo permite enviar los valores para realizar una busqueda de vuelo.
  * @param search este objeto contiene las caracteristicas de la busqueda, origen, destino y fecha
  * @returns la lista vuelos que cumplan con las caracteristicas requeridas
  */
  getSearch(search:any):Observable<Searchresults[]>{
    //Se realiza la solicitud GET en un endpoint GetVuelos para obtener la informacion de los aeropuertos disponibles
    return this.httpclient.get<Searchresults[]>(this.url+'/VueloWEB/'+ search.origen + "/" + search.destino + "/" + search.fecha)
  }
}
 