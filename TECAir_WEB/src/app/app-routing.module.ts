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
import { BillingComponent } from './components/billing/billing.component';
import { BillingEmployeeComponent } from './components/billing-employee/billing-employee.component';
import { PaymentUserComponent } from './components/payment-user/payment-user.component';
import { PaymentEmployeeComponent } from './components/payment-employee/payment-employee.component';
import { TicketViewComponent } from './components/ticket-view/ticket-view.component';
import { FlightSummaryComponent } from './components/flight-summary/flight-summary.component';


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
  {path: 'employeeBooking', component: BookingEmployeeComponent},
  {path: 'create-promotions', component: PromotionsComponent},
  {path: 'flights', component: FlightsComponent},
  {path: 'billing', component: BillingComponent},
  {path: 'billingEmployee', component: BillingEmployeeComponent},
  {path: 'ticketView', component: TicketViewComponent},
  {path: 'paymentUser', component: PaymentUserComponent},
  {path: 'paymentEmployee', component: PaymentEmployeeComponent},
  {path: 'flightSummary', component: FlightSummaryComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
