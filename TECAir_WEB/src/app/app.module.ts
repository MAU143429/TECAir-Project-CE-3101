import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { BookingsComponent } from './components/bookings/bookings.component';
import { BaggageComponent } from './components/baggage/baggage.component';
import { FlightsComponent } from './components/flights/flights.component';
import { UnavbarComponent } from './components/unavbar/unavbar.component';
import { EnavbarComponent } from './components/enavbar/enavbar.component';
import { SearchComponent } from './components/search/search.component';
import { PromotionsComponent } from './components/promotions/promotions.component';
import { LoginUserComponent } from './components/login-user/login-user.component';
import { HomeUserComponent } from './components/home-user/home-user.component';
import { HomeEmployeeComponent } from './components/home-employee/home-employee.component';
import { LoginEmployeeComponent } from './components/login-employee/login-employee.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RegisterComponent,
    BookingsComponent,
    BaggageComponent,
    FlightsComponent,
    UnavbarComponent,
    EnavbarComponent,
    SearchComponent,
    PromotionsComponent,
    LoginUserComponent,
    HomeUserComponent,
    HomeEmployeeComponent,
    LoginEmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
