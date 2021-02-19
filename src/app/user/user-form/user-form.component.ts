import { Component, OnInit } from '@angular/core';
import {UserService} from '../../shared/user.service';
import { NgForm } from '@angular/forms';
@Component({
  selector: 'app-user-detail-form',
  templateUrl: './user-form.component.html',
  styles: [
  ]
})
export class UserFormComponent implements OnInit {

  constructor(public service: UserService) { }

  ngOnInit(): void {
  }

}
