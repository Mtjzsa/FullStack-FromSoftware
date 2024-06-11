import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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
  snackBar: MatSnackBar
  loginModel: LoginModel

  logFormGroup = new FormGroup({
    username : new FormControl('', [Validators.required]),
    pw : new FormControl('', [Validators.required])
  })
  
  
  constructor (http : HttpClient, snackBar: MatSnackBar, router: Router) {
  this.snackBar = snackBar
  this.http = http
  this.router = router
  this.loginModel = new LoginModel()
 
}

  

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
        this.router.navigate(['/home'])
      },
      (error)=>{
        this.snackBar.open('Login failed: Username not found/wrong', 'Close', {duration : 5000})
      }
    )
  }

  errorMsgLog(str: string) {
    if (this.logFormGroup.get(str)?.hasError('required') && this.logFormGroup.get(str)?.touched){
      return 'Kitöltés kötelező!';
    }
    return null;
  }
}
