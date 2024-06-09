import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewBossComponent } from './view-boss.component';

describe('ViewBossComponent', () => {
  let component: ViewBossComponent;
  let fixture: ComponentFixture<ViewBossComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ViewBossComponent]
    });
    fixture = TestBed.createComponent(ViewBossComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
