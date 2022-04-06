import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { BookingsComponent } from './components/bookings/bookings.component';
import { BaggageComponent } from './components/baggage/baggage.component';
import { FlightsComponent } from './components/flights/flights.component';
import { SearchComponent } from './components/search/search.component';
import { PromotionsComponent } from './components/promotions/promotions.component';
import { LoginUserComponent } from './components/login-user/login-user.component';
import { HomeUserComponent } from './components/home-user/home-user.component';
import { HomeEmployeeComponent } from './components/home-employee/home-employee.component';
import { LoginEmployeeComponent } from './components/login-employee/login-employee.component';



const routes: Routes = [

  {path: '', component: HomeComponent},
  {path: 'loginuser' , component: LoginUserComponent},
  {path: 'loginemployee' , component: LoginEmployeeComponent},
  {path: 'homeuser', component: HomeUserComponent},
  {path: 'homeemployee', component: HomeEmployeeComponent},
  {path: 'baggage', component: BaggageComponent},
  {path: 'register', component: RegisterComponent},
  {path: 'searchFlights', component: SearchComponent},
  {path: 'booking', component: BookingsComponent},
  {path: 'create-promotions', component: PromotionsComponent},
  {path: 'flights', component: FlightsComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
