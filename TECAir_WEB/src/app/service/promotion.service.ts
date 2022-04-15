import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Promotion } from '../model/promotion';


@Injectable({
  providedIn: 'root'
})
export class PromotionService {

  url = 'https://localhost:7038/api'

  constructor(private httpclient:HttpClient) { }

  /** POST PARA CREAR PROMOCION
   *  Este post permite enviar la informacion de una promocion para que esta sea registrada.
   */
  addPromotion(promotion:any):Observable<any>{
    return this.httpclient.post(this.url+'/Promocion/Add', promotion) 
  }
}
