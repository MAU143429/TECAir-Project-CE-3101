import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from 'src/app/model/login';
import { LoginInterface } from 'src/app/interface/login-interface'
import { CredentialsService } from 'src/app/service/credentials.service';

@Component({
  selector: 'app-login-user',
  templateUrl: './login-user.component.html',
  styleUrls: ['./login-user.component.css']
})
export class LoginUserComponent implements OnInit {

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
    this.service.getLoginUser(newLogin).subscribe(data => (this.status = data));
    this.delay(500).then(()=>{
      if (this.status[0].status){
        this.router.navigate(['/homeuser']);
      }
    });
  }
}
 