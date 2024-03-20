import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateModule12978Component } from './create-module12978.component';

describe('CreateModule12978Component', () => {
  let component: CreateModule12978Component;
  let fixture: ComponentFixture<CreateModule12978Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateModule12978Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateModule12978Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
