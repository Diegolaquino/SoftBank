import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {ErrorHandler} from '../app.error-handler';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { BankStatement } from '../Models/bankStatement.model';

@Injectable({
  providedIn: 'root'
})
export class AccountTransationsService {

  private readonly baseUrl = 'http://localhost:5000/api/AccountTransactions';

  constructor(private http: HttpClient) { }

  getBankStatements(){
    return this.http.get<BankStatement[]>(this.baseUrl + "/BankStatement");
  }

  authenticateUser(accountLogin){
    return this.http.post(this.baseUrl + "/login", accountLogin);
  }



}
