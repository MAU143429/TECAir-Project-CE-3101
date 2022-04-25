import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PromotionsData } from '../interface/promotions-data'


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


  /** GET DE PROMOCIONES RANDOM
  * Este metodo permite recibir promociones aleatorias para mostrarlas
  * @returns la lista de 8 promociones aleatorias
  */
   getRandomPromotions():Observable<PromotionsData[]>{
    //Se realiza la solicitud GET en un endpoint GetVuelos para obtener la informacion de los aeropuertos disponibles
   return this.httpclient.get<PromotionsData[]>(this.url+'/Promocion/GetAll')
 }


}
 