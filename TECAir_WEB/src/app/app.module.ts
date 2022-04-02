import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { LoginComponent } from './components/login/login.component';
import { SflightsComponent } from './components/sflights/sflights.component';
import { BookingsComponent } from './components/bookings/bookings.component';
import { COffersComponent } from './components/c-offers/c-offers.component';
import { BaggageComponent } from './components/baggage/baggage.component';
import { CoffersComponent } from './components/coffers/coffers.component';
import { FlightsComponent } from './components/flights/flights.component';
import { UnavbarComponent } from './components/unavbar/unavbar.component';
import { EnavbarComponent } from './components/enavbar/enavbar.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RegisterComponent,
    LoginComponent,
    SflightsComponent,
    BookingsComponent,
    COffersComponent,
    BaggageComponent,
    CoffersComponent,
    FlightsComponent,
    UnavbarComponent,
    EnavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
