import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SflightsComponent } from './sflights.component';

describe('SflightsComponent', () => {
  let component: SflightsComponent;
  let fixture: ComponentFixture<SflightsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SflightsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SflightsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
