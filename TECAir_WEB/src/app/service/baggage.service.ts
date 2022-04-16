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
   *  Este post permite enviar la informacion de una promocion para que esta sea registrada.
   */
   newCheckin(checkin:any):Observable<any>{
    return this.httpclient.post(this.url+'/Chequeo/New', checkin) 
  }

}
