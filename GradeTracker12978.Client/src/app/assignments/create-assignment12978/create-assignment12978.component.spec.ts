import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateAssignment12978Component } from './create-assignment12978.component';

describe('CreateAssignment12978Component', () => {
  let component: CreateAssignment12978Component;
  let fixture: ComponentFixture<CreateAssignment12978Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateAssignment12978Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateAssignment12978Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
