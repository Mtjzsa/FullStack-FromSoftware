import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Boss } from '../_models/Boss';
import { Game } from '../_models/Game';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{

  http : HttpClient
  bosses: Array<Boss>
  games: Array<Game>

  constructor(http: HttpClient) {
      this.http = http,
      this.bosses = [],
      this.games = []
  }

  ngOnInit(): void {
    this.http.get<Array<Boss>>('http://localhost:5146/Boss')
    .subscribe(resp => {
      resp.map(x=>{
        let s = new Boss()
        s.id = x.id
        s.game_id = x.game_id
        s.bossName = x.bossName
        s.defense = x.defense
        s.hp = x.hp
        s.location = x.location
        s.souls = x.souls
        s.image = x.image
        this.bosses.push(s)
      })
      console.log(this.bosses)
    })

    this.http.get<Array<Game>>('http://localhost:5146/Game')
    .subscribe(resp => {
      resp.map(x=>{
        let g = new Game()
        g.id = x.id
        g.gameName = x.gameName
        g.releaseDate = x.releaseDate
        g.gameCover = x.gameCover
        g.bosses = x.bosses
        this.games.push(g)
      })
      console.log(this.games)
    })
  }

  
  
}
