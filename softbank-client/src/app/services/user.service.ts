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

  private readonly baseUrl = 'http://localhost:5000/api/home/Teste';

  constructor(private http: HttpClient) { }

  getAccountInformation(account){
    console.log('aqui');
    return this.http.get(this.baseUrl);
  }



}
