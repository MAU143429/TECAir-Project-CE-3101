import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CredentialsService {

  url = 'https://localhost:7038/api'

  constructor(private httpclient:HttpClient) { }


 /** POST PARA CREAR USUARIO
 *  Este post permite enviar la informacion para crear un usuario.
 */
    addRegister(register:any):Observable<any>{
    return this.httpclient.post(this.url+'/Usuario/Add', register) 
  }

   /** POST PARA CREAR PROMOCION
   *  Este post permite enviar la informacion para iniciar sesion.
   */
    newLogin(login:any):Observable<any>{
    return this.httpclient.post(this.url+'/Usuario/New', login) 
  }
}
 