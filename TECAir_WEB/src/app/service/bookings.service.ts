import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TicketPayment } from '../model/ticket-payment';

@Injectable({
  providedIn: 'root'
})
export class BookingsService {

  url = 'https://localhost:7038/api'

  constructor(private httpclient:HttpClient) { }

    /** POST PARA ENVIAR DATOS DE PASAJERO LUEGO DEL PAGO DEL TIQUETE
   *  Este post permite enviar la informacion del pasajero luego de que este compro el tiquete 
   *  esto para que quede registrada.
   */
     addTicketPayment(ticket:any):Observable<any>{
      return this.httpclient.post(this.url+'/Ticket/Add', ticket) 
    }
}
