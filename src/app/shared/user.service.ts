import { Injectable } from '@angular/core';
import {User} from './user.model';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(/*private http: HttpClient*/) { }
  // readonly baseURL = 'http://localhost:60940/api/Users';
  formData: User = new User();
}
