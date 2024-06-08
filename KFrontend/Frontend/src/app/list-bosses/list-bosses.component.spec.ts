import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListBossesComponent } from './list-bosses.component';

describe('ListBossesComponent', () => {
  let component: ListBossesComponent;
  let fixture: ComponentFixture<ListBossesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListBossesComponent]
    });
    fixture = TestBed.createComponent(ListBossesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
