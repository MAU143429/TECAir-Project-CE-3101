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


  /** POST PARA CREAR ASIENTO
   *  Este post permite enviar la informacion del asiento de un pasajero
   */
   newSeat(seat:any):Observable<any>{
     console.log("Se agrega el asiento")
     console.log(seat)
    return this.httpclient.post(this.url+'/Asiento/Add', seat) 
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
     console.log("SE ENVIAR PARA CHEQUEAR AL PASAJERO CON NUMERO DE TRANSACCION")
     console.log(openFlight)
    return this.httpclient.put(this.url+'/Tiquete/CheckIn/', openFlight) 
  }

 
   getFullTicket(ticket:any):Observable<any>{
    return this.httpclient.get(this.url+'/Tiquete/GetTVuelo/' +ticket.no_transaccion) 
  }

}
