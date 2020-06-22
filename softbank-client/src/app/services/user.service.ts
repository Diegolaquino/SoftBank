import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor() { }

  public printar(){
    console.log('user service orraaaa');
  }

}
