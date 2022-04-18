import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from 'src/app/model/login';
import { LoginInterface } from 'src/app/interface/login-interface'
import { CredentialsService } from 'src/app/service/credentials.service';

@Component({
  selector: 'app-login-employee',
  templateUrl: './login-employee.component.html',
  styleUrls: ['./login-employee.component.css']
})
export class LoginEmployeeComponent implements OnInit {

  newLogin :Login = new Login
  status:LoginInterface[] | any;
  direction:string = "/homeemployee";

  constructor(private service:CredentialsService, private router:Router) { }

  ngOnInit(): void {
  }

  // Metodo para consultar un nuevo inicio de sesion en web
  addNewLogin(newLogin:Login){
    this.service.getLogin(newLogin).subscribe(data => (this.status = data));
    if (!this.status[0].status){
      this.direction = "loginemployee"
    }
  }
}
 