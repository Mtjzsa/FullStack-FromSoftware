import { Component } from '@angular/core';
import { Game } from '../_models/game';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-game',
  templateUrl: './create-game.component.html',
  styleUrls: ['./create-game.component.scss']
})
export class CreateGameComponent {
  http: HttpClient
  game: Game
  router: Router
  snackBar: MatSnackBar

  constructor(http: HttpClient, snackBar: MatSnackBar, router : Router) {
    this.http = http
    this.game = new Game()
    this.router = router
    this.snackBar = snackBar
  }

  public createGame() : void {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
    })
    this.http
      .post(
        'http://localhost:5146/Game',
        this.game,
        { headers: headers }
      )
      .subscribe(
        (success) => {
          this.snackBar.open('Create was successful!', 'Close', { duration: 5000 })
          this.router.navigate(['/list-games'])
        },
        (error) => {
          this.snackBar.open('Error occured, please try again.', 'Close', { duration: 5000 })
        }
      )
  }
}
