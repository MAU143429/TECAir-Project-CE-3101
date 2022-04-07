import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { BaggageComponent } from './components/baggage/baggage.component';
import { FlightsComponent } from './components/flights/flights.component';
import { PromotionsComponent } from './components/promotions/promotions.component';
import { LoginUserComponent } from './components/login-user/login-user.component';
import { HomeUserComponent } from './components/home-user/home-user.component';
import { HomeEmployeeComponent } from './components/home-employee/home-employee.component';
import { LoginEmployeeComponent } from './components/login-employee/login-employee.component';
import { SearchUserComponent } from './components/search-user/search-user.component';
import { SearchEmployeeComponent } from './components/search-employee/search-employee.component';
import { BookingUserComponent } from './components/booking-user/booking-user.component';
import { BookingEmployeeComponent} from './components/booking-employee/booking-employee.component';



const routes: Routes = [

  {path: '', component: HomeComponent},
  {path: 'loginuser' , component: LoginUserComponent},
  {path: 'loginemployee' , component: LoginEmployeeComponent},
  {path: 'homeuser', component: HomeUserComponent},
  {path: 'homeemployee', component: HomeEmployeeComponent},
  {path: 'baggage', component: BaggageComponent},
  {path: 'register', component: RegisterComponent},
  {path: 'userSearchFlights', component: SearchUserComponent},
  {path: 'employeeSearchFlights', component: SearchEmployeeComponent},
  {path: 'userBooking', component: BookingUserComponent},
  {path: 'EmployeeBooking', component: BookingEmployeeComponent},
  {path: 'create-promotions', component: PromotionsComponent},
  {path: 'flights', component: FlightsComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
