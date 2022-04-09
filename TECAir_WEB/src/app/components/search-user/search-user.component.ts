import { Component, OnInit } from '@angular/core';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-search-user',
  templateUrl: './search-user.component.html',
  styleUrls: ['./search-user.component.css']
})
export class SearchUserComponent implements OnInit {

  takeoff: NgbDateStruct | undefined;
  landing: NgbDateStruct | undefined;
  constructor() { }

  ngOnInit(): void {
  }

}
