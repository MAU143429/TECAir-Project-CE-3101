import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BillingEmployeeComponent } from './billing-employee.component';

describe('BillingEmployeeComponent', () => {
  let component: BillingEmployeeComponent;
  let fixture: ComponentFixture<BillingEmployeeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BillingEmployeeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BillingEmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
