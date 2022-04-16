import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Search } from '../model/search';


@Injectable({
  providedIn: 'root'
})
export class SearchflightsService {

  url = 'https://localhost:7038/api'

  constructor(private httpclient:HttpClient) { }

  /** POST PARA REALIZAR BUSQUEDA
   *  Este post permite enviar la informacion para realizar una busqueda de un vuelo.
   */
  newSearch(search:any):Observable<any>{
    return this.httpclient.post(this.url+'/Search/New', search) 
  }
}
 