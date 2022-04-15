import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BaggageCheckComponent } from './baggage-check.component';

describe('BaggageCheckComponent', () => {
  let component: BaggageCheckComponent;
  let fixture: ComponentFixture<BaggageCheckComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BaggageCheckComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BaggageCheckComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
