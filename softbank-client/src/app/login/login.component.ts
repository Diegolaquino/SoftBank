import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { AccountLogin } from '../Models/accountLogin.model';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  accountLogin: AccountLogin = new AccountLogin();
  customer: string;

  constructor(private userService: UserService, private router: Router,  private routerr: ActivatedRoute) { 

    let questoesParam = this.routerr
    .queryParamMap
    .map(params => params.get('customer') || 'None');

    console.log(questoesParam);
  }

  ngOnInit() {
    
  }

  onSubmit(){
    this.accountLogin.role = "Admin";
    
    this.userService.authenticateUser(this.accountLogin).subscribe(
      data => console.log(data)
    );
  }



}
