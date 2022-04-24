import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaggageService {

  url = 'https://localhost:7038/api'

  constructor(private httpclient:HttpClient) { }

  /** POST PARA CREAR MALETA
   *  Este post permite enviar la informacion de una promocion para que esta sea registrada.
   */
  addBaggage(baggage:any):Observable<any>{
    return this.httpclient.post(this.url+'/Maleta/Add', baggage) 
  }

  /** POST HACER CHECK-IN
   *  Este post permite enviar la informacion de un pasajero para que este sea chequeado
   */
   newCheckin(checkin:any):Observable<any>{
    return this.httpclient.post(this.url+'Pasajero/Chequeo', checkin) 
  }

  /** GET PARA CHEQUEO
  *  Este get permite solicitar la informacion de un pasajero
  */
    getCheckData(openFlight:any):Observable<any>{
    return this.httpclient.get(this.url+'/Tiquete/GetT/' +  openFlight) 
  }

  /** PUT PARA CHEQUEO
  *  Este put actualiza el valor del pasajero a chequeadp
  */
   putCheckIn(openFlight:any):Observable<any>{
    return this.httpclient.get(this.url+'/Tiquete/Put/' +  openFlight) 
  }

  /** PUT PARA CHEQUEO
  *  Este put actualiza el valor del pasajero a chequeadp
  */
   getFullTicket(ticket:any):Observable<any>{
    return this.httpclient.get(this.url+'/Tiquete/Get/' +  ticket.no_vuelo +"/"+ticket.no_transaccion) 
  }

}
