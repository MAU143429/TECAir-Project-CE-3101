import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { Login } from 'src/app/model/login';
import { LoginInterface } from 'src/app/interface/login-interface'
import { CredentialsService } from 'src/app/service/credentials.service';
import { delay } from 'rxjs';

@Component({
  selector: 'app-login-employee',
  templateUrl: './login-employee.component.html',
  styleUrls: ['./login-employee.component.css']
})
export class LoginEmployeeComponent implements OnInit {

  newLogin :Login = new Login
  status:LoginInterface[] | any;


  constructor(private service:CredentialsService, private router:Router) { }

  ngOnInit(): void {
  }

  async delay(ms: number) {
    await new Promise<void>(resolve => setTimeout(()=>resolve(), ms)).then(()=>console.log("fired"));
  }

  // Metodo para consultar un nuevo inicio de sesion en web
  addNewLogin(newLogin:Login){
    this.service.getLoginEmployee(newLogin).subscribe(data => (this.status = data));
    this.delay(500).then(()=>{
      console.log(this.status[0].status)
      if (this.status[0].status){
        this.router.navigate(['/homeemployee']);
      }
    });
  } 
}
 