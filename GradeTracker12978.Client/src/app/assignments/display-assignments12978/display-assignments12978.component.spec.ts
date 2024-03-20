import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayAssignments12978Component } from './display-assignments12978.component';

describe('DisplayAssignments12978Component', () => {
  let component: DisplayAssignments12978Component;
  let fixture: ComponentFixture<DisplayAssignments12978Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DisplayAssignments12978Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DisplayAssignments12978Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
