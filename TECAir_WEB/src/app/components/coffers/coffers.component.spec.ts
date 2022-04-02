import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CoffersComponent } from './coffers.component';

describe('CoffersComponent', () => {
  let component: CoffersComponent;
  let fixture: ComponentFixture<CoffersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CoffersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CoffersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
