import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { AccountLogin } from '../Models/accountLogin.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  accountLogin: AccountLogin = new AccountLogin();

  constructor(private userService: UserService) { }

  ngOnInit() {
  }

  onSubmit(){
    this.accountLogin.role = "Admin";
    console.log(this.accountLogin);
    this.userService.authenticateUser(this.accountLogin).subscribe(
      console.log
    );
  }



}
