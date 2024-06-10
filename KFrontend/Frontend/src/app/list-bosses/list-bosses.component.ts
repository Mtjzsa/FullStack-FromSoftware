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
  searchTerm: string = '';
  
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
    })
  }


  public getGame(boss : Boss, games : Array<Game>) : string {
    const game = games.find(game => game.id === boss.game_Id);
    return game ? game.gameName : 'No game';
  }

  public filteredBosses(): Array<Boss> {
    return this.bosses.filter(boss =>
      boss.bossName.toLowerCase().includes(this.searchTerm.toLowerCase())
    );
  }
}
