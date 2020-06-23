import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { AccountDiscovery } from '../Models/accountDiscovery.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  account: AccountDiscovery = new AccountDiscovery();
  submitted = false;

  constructor(private userService: UserService, private router: Router) { }

  ngOnInit() {
  }

  onSubmit(){
    //console.log(this.account);
    let t = this.userService.getAccountInformation(this.account).subscribe(
      data => {  if(data != null){
        this.submitted = true;
      }  }
    );
   
  }

  newAccount(): void {
    this.submitted = false;
    this.account = new AccountDiscovery();
  }

}
