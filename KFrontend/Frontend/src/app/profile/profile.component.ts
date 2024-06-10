import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AppUser } from '../_models/appuser';
import { ActivatedRoute, Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit{
  http: HttpClient
  appUser : AppUser
  route: ActivatedRoute
  router : Router
  snackbar: MatSnackBar

  constructor(http: HttpClient, route: ActivatedRoute, snackBar: MatSnackBar, router: Router) {
    this.http = http
    this.appUser = new AppUser
    this.route = route
    this.router = router
    this.snackbar = snackBar
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

  public deleteMyself(){
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
    })
    this.http
    .delete(
      'http://localhost:5146/Auth/',
      { headers: headers}
    )
    .subscribe(
      (success)=>{
        this.snackbar.open("Delete was successful!", "Close", {duration: 5000})
        localStorage.setItem('nikprog-practiceapi-token', '')
        localStorage.setItem('nikprog-practiceapi-token-expiration', '')
        localStorage.clear()
        this.router.navigate(['/home'])
      },
      (error)=>{
        this.snackbar.open("Error occured, please try again.", "Close", {duration: 5000})
      }
    )
  }
}
