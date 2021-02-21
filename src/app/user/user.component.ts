import { Component, OnInit } from '@angular/core';
import {UserService} from '../shared/user.service';
import {User} from '../shared/user.model';

@Component({
  selector: 'app-user-details',
  templateUrl: './user.component.html',
  providers: [UserService]
})
export class UserComponent implements OnInit {

  constructor(public service: UserService){}

  user: User = new User();
  listUser: User[];
  countActive = 0;
  total = 0;
    ngOnInit(): void {
    this.loadProducts();
  }

  loadProducts() {
   this.service.getProducts()
      .subscribe((data: User[]) => this.listUser = data);
  }

  GetCount(): void {
    this.service.getCountActive().subscribe((count: number) =>
      this.countActive = count);
    this.total = this.listUser.length;
  }

  editProduct(p: User) {
    this.user = p;
    this.service.updateProduct(this.user)
      .subscribe(() => this.loadProducts());
    console.log(this.user);
  }
}
