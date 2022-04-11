import { Component, OnInit } from '@angular/core';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-search-employee',
  templateUrl: './search-employee.component.html',
  styleUrls: ['./search-employee.component.css']
})
export class SearchEmployeeComponent implements OnInit {

  takeoff: NgbDateStruct | undefined;
  landing: NgbDateStruct | undefined;

  constructor() { }

  ngOnInit(): void {
  }

}
