import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Desigation } from './desigation';

describe('Desigation', () => {
  let component: Desigation;
  let fixture: ComponentFixture<Desigation>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Desigation],
    }).compileComponents();

    fixture = TestBed.createComponent(Desigation);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
