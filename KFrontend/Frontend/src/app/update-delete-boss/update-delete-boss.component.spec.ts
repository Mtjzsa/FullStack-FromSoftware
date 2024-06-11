import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateDeleteBossComponent } from './update-delete-boss.component';

describe('UpdateDeleteBossComponent', () => {
  let component: UpdateDeleteBossComponent;
  let fixture: ComponentFixture<UpdateDeleteBossComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateDeleteBossComponent]
    });
    fixture = TestBed.createComponent(UpdateDeleteBossComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
