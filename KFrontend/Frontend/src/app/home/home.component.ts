import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Game } from '../_models/game';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit{
  
  http : HttpClient
  games : Array<Game>

  constructor(http : HttpClient) {
    this.http = http
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
      console.log(this.games)
    })
  }  

  moveSlider(direction: string) {
    if (direction === 'prev') {
      const lastItem = this.games.pop();
      if (lastItem) {
        this.games.unshift(lastItem);
      }
    }
  }
}



