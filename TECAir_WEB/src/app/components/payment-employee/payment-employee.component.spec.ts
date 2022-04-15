import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaymentEmployeeComponent } from './payment-employee.component';

describe('PaymentEmployeeComponent', () => {
  let component: PaymentEmployeeComponent;
  let fixture: ComponentFixture<PaymentEmployeeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaymentEmployeeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaymentEmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
