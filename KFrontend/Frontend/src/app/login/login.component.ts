import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { LoginModel } from '../_models/loginmodel';
import { TokenModel } from '../_models/tokenmodel';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  router: Router
  http: HttpClient
  // username: FormControl
  snackBar: MatSnackBar
  loginModel: LoginModel
  
  constructor (http : HttpClient, snackBar: MatSnackBar, router: Router) {
  this.snackBar = snackBar
  this.http = http
  this.router = router
  this.loginModel = new LoginModel()
  // this.username = new FormControl('', [Validators.required, Validators.email])
}

//public getEmailErrorMessage() : string {
  // if  (this.username.hasError('required')){
  //   return 'You must enter a value!'
  // }

  // return this.email.hasError('email') ? 'Not a valid email!' : ''
  //return this.loginModel.userName
//}

public checkInputs() : boolean{
  return this.loginModel.userName !== '' && this.loginModel.password !== ''
}

public sendLoginCredentials() : void{
  this.http
  .post<TokenModel>("http://localhost:5146/Auth", this.loginModel)
  .subscribe(
    (success) =>{
      localStorage.setItem('nikprog-practiceapi-token', success.token)
      localStorage.setItem('nikprog-practiceapi-token-expiration', success.expiration.toString())
      // console.log(success)
      this.router.navigate(['/home'])
    },
    (error)=>{
      // console.log(error)
      this.snackBar.open(error.message, 'Close', {duration : 5000})
    }
  )
  
}
}
