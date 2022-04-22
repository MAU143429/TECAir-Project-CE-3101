import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule , ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgxMatTimepickerModule } from 'ngx-mat-timepicker';
import { MatFormFieldModule } from '@angular/material/form-field'
import { MatInputModule } from '@angular/material/input';
import { CarouselModule } from 'ngx-owl-carousel-o';
import { HttpClientModule} from '@angular/common/http';
import {MatAutocompleteModule} from '@angular/material/autocomplete';


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
import { BillingComponent } from './components/billing/billing.component';
import { BillingEmployeeComponent } from './components/billing-employee/billing-employee.component';
import { PaymentUserComponent } from './components/payment-user/payment-user.component';
import { PaymentEmployeeComponent } from './components/payment-employee/payment-employee.component';
import { TicketViewComponent } from './components/ticket-view/ticket-view.component';
import { FlightSummaryComponent } from './components/flight-summary/flight-summary.component';

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
    BookingEmployeeComponent,
    BillingComponent,
    BillingEmployeeComponent,
    PaymentUserComponent,
    PaymentEmployeeComponent,
    TicketViewComponent,
    FlightSummaryComponent,

    
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    NgbModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    NgxMatTimepickerModule,
    HttpClientModule,
    CarouselModule,
    MatAutocompleteModule,
    ReactiveFormsModule,

  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {
}
