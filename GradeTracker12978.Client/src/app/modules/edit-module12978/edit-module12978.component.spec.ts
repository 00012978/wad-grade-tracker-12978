import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditModule12978Component } from './edit-module12978.component';

describe('EditModule12978Component', () => {
  let component: EditModule12978Component;
  let fixture: ComponentFixture<EditModule12978Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditModule12978Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditModule12978Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
