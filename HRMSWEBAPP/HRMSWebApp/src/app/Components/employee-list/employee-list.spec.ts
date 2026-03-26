import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EMployeeList } from './employee-list';

describe('EMployeeList', () => {
  let component: EMployeeList;
  let fixture: ComponentFixture<EMployeeList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EMployeeList],
    }).compileComponents();

    fixture = TestBed.createComponent(EMployeeList);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
