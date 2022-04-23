import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TicketPayment } from '../model/ticket-payment';
import { BookingData } from 'src/app/interface/booking-data';

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

    /** GET DE BUSQUEDA
  * Este metodo permite enviar los valores para realizar una busqueda de vuelo.
  * @param search este objeto contiene las caracteristicas de la busqueda, origen, destino y fecha
  * @returns la lista vuelos que cumplan con las caracteristicas requeridas
  */
  getBookings():Observable<BookingData[]>{
    //Se realiza la solicitud GET en un endpoint GetVuelos para obtener la informacion de los aeropuertos disponibles
   return this.httpclient.get<BookingData[]>(this.url+'/Reservacion/Get')
 }
}
