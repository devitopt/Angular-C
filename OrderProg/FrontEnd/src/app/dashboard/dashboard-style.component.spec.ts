import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardStyleComponent } from './dashboard-style.component';

describe('DashboardStyleComponent', () => {
  let component: DashboardStyleComponent;
  let fixture: ComponentFixture<DashboardStyleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DashboardStyleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardStyleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
