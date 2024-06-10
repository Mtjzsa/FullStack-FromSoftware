import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Boss } from '../_models/boss';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Game } from '../_models/game';

@Component({
  selector: 'app-create-boss',
  templateUrl: './create-boss.component.html',
  styleUrls: ['./create-boss.component.scss']
})
export class CreateBossComponent implements OnInit {
  http: HttpClient
  boss: Boss
  snackBar: MatSnackBar
  games : Array<Game>

  constructor(http: HttpClient, snackBar: MatSnackBar) {
    this.http = http
    this.boss = new Boss()
    this.games = []
    this.snackBar = snackBar
  }
  
  ngOnInit(): void {
    this.http.get<Array<Game>>('http://localhost:5146/Game')
    .subscribe(resp => {
      resp.map(x=>{
        let s = new Game()
        s.id = x.id
        s.gameName = x.gameName
        s.gameCover = x.gameCover
        s.releaseDate = x.releaseDate
        s.bosses = x.bosses
        s.gameDescription = x.gameDescription
        this.games.push(s)
      })
    })
  }

  public createBoss() : void{
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
    })
    this.http
      .post(
        'http://localhost:5146/Boss',
        this.boss,
        { headers: headers }
      )
      .subscribe(
        (success) => {
          this.snackBar.open('Create was successful!', 'Close', { duration: 5000 })
        },
        (error) => {
          this.snackBar.open('Error occured, please try again.', 'Close', { duration: 5000 })
        }
      )
  }

}
