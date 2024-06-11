import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingalrserviceComponent } from './singalrservice.component';

describe('SingalrserviceComponent', () => {
  let component: SingalrserviceComponent;
  let fixture: ComponentFixture<SingalrserviceComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SingalrserviceComponent]
    });
    fixture = TestBed.createComponent(SingalrserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
