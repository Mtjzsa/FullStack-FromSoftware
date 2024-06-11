import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Game } from '../_models/game';
import { ActivatedRoute } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-view-games',
  templateUrl: './view-games.component.html',
  styleUrls: ['./view-games.component.scss']
})
export class ViewGamesComponent implements OnInit{
  http: HttpClient
  route: ActivatedRoute
  snackBar:MatSnackBar
  game : Game
  deleteDisabled: boolean

  constructor(http: HttpClient, route:ActivatedRoute, snackBar:MatSnackBar) {
    this.http = http
    this.route = route
    this.game = new Game()
    this.snackBar = snackBar
    this.deleteDisabled = true
  }
  ngOnInit(): void {
    this.route.params.subscribe(param =>{
      let gameName = param['gameName']
      let headers = new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
      })

      this.http.get<any>('http://localhost:5146/Game/'+ gameName, {headers: headers})
      .subscribe(resp =>{
          this.game.id = resp.id
          this.game.gameName = resp.gameName
          this.game.bosses = resp.bosses
          this.game.gameCover = resp.gameCover
          this.game.gameDescription = resp.gameDescription
          this.game.releaseDate = resp.releaseDate
      })
        console.log(this.game)
    })
  }
}
