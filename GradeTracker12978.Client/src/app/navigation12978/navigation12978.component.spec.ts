import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Navigation12978Component } from './navigation12978.component';

describe('Navigation12978Component', () => {
  let component: Navigation12978Component;
  let fixture: ComponentFixture<Navigation12978Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Navigation12978Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Navigation12978Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
