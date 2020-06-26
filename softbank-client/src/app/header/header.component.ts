import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { AccountDiscovery } from '../Models/accountDiscovery.model';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  token = "";
  account: AccountDiscovery = new AccountDiscovery();
  submitted = false;
  customer = "";


  constructor(private userService: UserService, private router: Router) { }

  ngOnInit() {
  }

  onSubmit(){
    
    this.userService.getAccountInformation(this.account).subscribe(
      data => {
        this.customer = data['customer'];
      }
    );
    this.router.navigate(['/login']);
    this.submitted = true;
    
   
  }

  newAccount(): void {
    this.submitted = false;
    this.account = new AccountDiscovery();
  }

}
