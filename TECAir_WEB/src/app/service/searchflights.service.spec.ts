import { TestBed } from '@angular/core/testing';

import { SearchflightsService } from './searchflights.service';

describe('SearchflightsService', () => {
  let service: SearchflightsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SearchflightsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
