import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
@Injectable({
providedIn: 'root'
})

export class ConnectionService {

private no_vuelo:any;
private no_reservacion:any; 
private no_transaccion:any; 

sendClickEvent(novuelo:any,noreservacion:any) {
  this.no_vuelo = novuelo;
  this.no_reservacion = noreservacion;
}

sendClickEvent2(novuelo:any,notransaccion:any) {
  this.no_vuelo = novuelo;
  this.no_transaccion = notransaccion;
}

getNoVueloEvent(): Observable<any>{ 
  return this.no_vuelo;
}

getNoReservacionEvent(): Observable<any>{
   return this.no_reservacion;
}

getNoTransaccionEvent(): Observable<any>{
 return this.no_transaccion;
}

}
