import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EMployeeForm } from './employee-form';

describe('EMployeeForm', () => {
  let component: EMployeeForm;
  let fixture: ComponentFixture<EMployeeForm>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EMployeeForm],
    }).compileComponents();

    fixture = TestBed.createComponent(EMployeeForm);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
