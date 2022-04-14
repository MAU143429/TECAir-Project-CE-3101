import { Component, OnInit } from '@angular/core';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { OwlOptions } from 'ngx-owl-carousel-o';

@Component({
  selector: 'app-home-user',
  templateUrl: './home-user.component.html',
  styleUrls: ['./home-user.component.css'],

})
export class HomeUserComponent implements OnInit {
  customOptions: OwlOptions = {
    loop: true,
    margin: 20,
    mouseDrag: true,
    touchDrag: true,
    pullDrag: true,
    autoplaySpeed:1000,
    autoplay:true,
    dots: true,
    navSpeed: 700,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1
      },
      400: {
        items: 2
      },
      740: {
        items: 3
      },
      940: {
        items: 4
      }
    },
    nav: true
  }
  constructor() { 
 
  }

  ngOnInit(): void {
  }

}
