import { Component, OnInit } from '@angular/core';
import { Customer } from '../Models/customer';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  customer : Customer;

  constructor(private route: Router) { }

  ngOnInit() {
    var dataUserInfo = sessionStorage.getItem('userInfo');

    if(dataUserInfo == null){
      this.route.navigate(['']);
    }

    var userInfo = JSON.parse(dataUserInfo);

    this.customer = userInfo.user;
  }

}
