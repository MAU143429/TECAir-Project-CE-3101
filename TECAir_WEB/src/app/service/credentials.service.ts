import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoginInterface } from '../interface/login-interface'
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
  
  /**
   * Este metodo nos permite enviar las credenciales del usuario/empleado para que sean verificadas
   * y se permita el inicio de sesion.
   * @param login 
   * @returns 
   */
  getLogin(login:any):Observable<LoginInterface[]>{
    //Se realiza la solicitud GET en un endpoint GetVuelos para obtener la informacion de los aeropuertos disponibles
    return this.httpclient.get<LoginInterface[]>(this.url+'/Usuario/'+ login.correo + "/" + login.contrasena)
  }
}
 