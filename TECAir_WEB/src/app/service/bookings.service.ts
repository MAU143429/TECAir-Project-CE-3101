import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TicketPayment } from '../model/ticket-payment';
import { BookingData } from 'src/app/interface/booking-data';
import { TicketData } from 'src/app/interface/ticket-data';

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
      return this.httpclient.post(this.url+'/Pasajero/Add', ticket) 
    }

    /** POST PARA ENVIAR DATOS DE LA RESERVACION Y TRAER EL DETALLE PARA EL PAGO
    *  Este post permite enviar la informacion para traer el detalle del tiquete
    */
     newBilling(billing:any):Observable<any>{
      return this.httpclient.post(this.url+'/Reservacion/', billing) 
    }

    /** GET DE RESERVACIONES
    * Este metodo permite recibir las reservaciones de un usuario.
    * @returns la lista reservaciones que cumplan con las caracteristicas requeridas
    */
    getBookings():Observable<BookingData[]>{
    return this.httpclient.get<BookingData[]>(this.url+'/Reservacion/Get')
  }

     /** GET DE TIQUETES
    * Este metodo permite recibir las tiquetes de un usuario.
    * @returns la lista tiquetes que cumplan con las caracteristicas requeridas
    */
    getTickets():Observable<TicketData[]>{
      return this.httpclient.get<TicketData[]>(this.url+'/Tiquete/Get')
    }
}
