import { TestBed } from '@angular/core/testing';

import { Module12978Service } from './module12978.service';

describe('Module12978Service', () => {
  let service: Module12978Service;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Module12978Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
