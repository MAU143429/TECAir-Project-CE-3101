import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Register } from 'src/app/model/register';
import { Login } from 'src/app/model/login';
import { CredentialsService } from 'src/app/service/credentials.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  newRegister:Register = new Register
  


  constructor(private service:CredentialsService, private router:Router) {}
  ngOnInit(): void {
    
    
  }
  
  // Metodo para agregar un nuevo usuario desde la seccion de registro
  addNewRegister(newRegister:Register){
    this.service.addRegister(newRegister).subscribe(register=> console.log(register));
  }
} 
