import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { BaggageComponent } from './components/baggage/baggage.component';
import { FlightsComponent } from './components/flights/flights.component';
import { UnavbarComponent } from './components/unavbar/unavbar.component';
import { EnavbarComponent } from './components/enavbar/enavbar.component';
import { PromotionsComponent } from './components/promotions/promotions.component';
import { LoginUserComponent } from './components/login-user/login-user.component';
import { HomeUserComponent } from './components/home-user/home-user.component';
import { HomeEmployeeComponent } from './components/home-employee/home-employee.component';
import { LoginEmployeeComponent } from './components/login-employee/login-employee.component';
import { SearchUserComponent } from './components/search-user/search-user.component';
import { SearchEmployeeComponent } from './components/search-employee/search-employee.component';
import { BookingUserComponent } from './components/booking-user/booking-user.component';
import { BookingEmployeeComponent } from './components/booking-employee/booking-employee.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RegisterComponent,
    BaggageComponent,
    FlightsComponent,
    UnavbarComponent,
    EnavbarComponent,
    PromotionsComponent,
    LoginUserComponent,
    HomeUserComponent,
    HomeEmployeeComponent,
    LoginEmployeeComponent,
    SearchUserComponent,
    SearchEmployeeComponent,
    BookingUserComponent,
    BookingEmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
