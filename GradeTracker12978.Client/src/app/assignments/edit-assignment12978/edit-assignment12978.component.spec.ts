import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditAssignment12978Component } from './edit-assignment12978.component';

describe('EditAssignment12978Component', () => {
  let component: EditAssignment12978Component;
  let fixture: ComponentFixture<EditAssignment12978Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditAssignment12978Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditAssignment12978Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
