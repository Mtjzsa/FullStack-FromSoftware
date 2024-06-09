import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Boss } from '../_models/boss';
import { Game } from '../_models/game';

@Component({
  selector: 'app-list-bosses',
  templateUrl: './list-bosses.component.html',
  styleUrls: ['./list-bosses.component.scss']
})
export class ListBossesComponent {
  http: HttpClient
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
        s.bossName = x.bossName
        s.game_Id = x.game_Id
        s.hp = x.hp
        s.defense = x.defense
        s.image = x.image
        s.location = x.location
        s.souls = x.souls
        s.description = x.description
        this.bosses.push(s)
      })
      console.log(this.bosses)
    })

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
      console.log(this.games)
    })
  }


  public getGame(boss : Boss, games : Array<Game>) : string {
    for (let i = 0; i < games.length; i++) {
      if (boss.game_Id === games[i].id){
        return games[i].gameName
      }
    }
    return "No game"
  }
}
