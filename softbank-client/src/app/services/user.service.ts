import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {ErrorHandler} from '../app.error-handler';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private readonly baseUrl = 'http://localhost:5000/api/accounts';

  constructor(private http: HttpClient) { }

  getAccountInformation(account){
    return this.http.get(this.baseUrl + "/AccountInformation", {params: account});
  }

  authenticateUser(accountLogin){
    return this.http.post(this.baseUrl + "/login", accountLogin);
  }



}
