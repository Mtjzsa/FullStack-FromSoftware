import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { RegisterModel } from '../_models/registermodel';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
  router: Router
  http: HttpClient
  snackBar: MatSnackBar
  registerModel: RegisterModel
  acceptTermsAndConditions: boolean

  regFormGroup = new FormGroup({
    username : new FormControl('', [Validators.required]),
    email : new FormControl('', [Validators.required]),
    pw : new FormControl('', [Validators.required]),
    firstName : new FormControl('', [Validators.required]),
    lastName : new FormControl('', [Validators.required]),
    check : new FormControl('', [Validators.required]),
  })

  constructor (http : HttpClient, snackBar: MatSnackBar, router: Router){
    this.snackBar = snackBar
    this.http = http
    this.router = router
    this.acceptTermsAndConditions = false
    this.registerModel = new RegisterModel()
    
  }

  public sendRegisterCredentials() : void {
    this.http.put("http://localhost:5146/Auth", this.registerModel)
    .subscribe(
      (success) =>{
        this.snackBar
        .open("Registration was successful!", "Close", {duration: 5000})
        .afterDismissed()
        .subscribe(() =>{
          this.router.navigate(['/login'])
        })
      },
      (error) =>{
        this.snackBar.open("An error happened, please try again...", "Close", {duration: 5000})
      })
  }

  errorMsgReg(str: string) {
    if (this.regFormGroup.get(str)?.hasError('required') && this.regFormGroup.get(str)?.touched){
      return 'Kitöltés kötelező!';
    }
    return null;
  }
}
