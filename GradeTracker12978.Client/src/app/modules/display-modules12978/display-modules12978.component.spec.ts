import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayModules12978Component } from './display-modules12978.component';

describe('DisplayModules12978Component', () => {
  let component: DisplayModules12978Component;
  let fixture: ComponentFixture<DisplayModules12978Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DisplayModules12978Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DisplayModules12978Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
