import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Game } from '../_models/game';

@Component({
  selector: 'app-list-games',
  templateUrl: './list-games.component.html',
  styleUrls: ['./list-games.component.scss']
})
export class ListGamesComponent implements OnInit{
  http: HttpClient
  games: Array<Game>

  
  constructor(http: HttpClient) {
    this.http = http,
    this.games = []
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
      this.games.sort((a, b) => b.bosses.length - a.bosses.length);

      console.log(this.games);
    })
  }
}
