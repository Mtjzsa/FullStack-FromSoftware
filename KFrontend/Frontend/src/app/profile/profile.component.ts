import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AppUser } from '../_models/appuser';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit{
  http: HttpClient
  appUser : AppUser

  constructor(http: HttpClient) {
    this.http = http
    this.appUser = new AppUser
  }

  ngOnInit(): void {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
    })
    this.http.get<AppUser>('http://localhost:5146/Auth/', {headers: headers})
    .subscribe(resp =>{
      this.appUser.userName = resp.userName
      this.appUser.firstName = resp.firstName
      this.appUser.lastName = resp.lastName
      this.appUser.email = resp.email
      this.appUser.defeatedBosses = resp.defeatedBosses
    })
  }

}
