import { TestBed } from '@angular/core/testing';

import { Assignment12978Service } from './assignment12978.service';

describe('Assignment12978Service', () => {
  let service: Assignment12978Service;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Assignment12978Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
