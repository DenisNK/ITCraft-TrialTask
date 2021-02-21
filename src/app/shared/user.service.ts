import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {User} from './user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'http://localhost:60940/api/Users';

  getProducts() {
    return this.http.get(this.baseURL);
  }

  getCountActive() {
   return this.http.get(`${this.baseURL}/GetCount`);
   }

  updateProduct(user: User) {
    return this.http.put(`${this.baseURL}/${user.id}`, user);
  }

}
