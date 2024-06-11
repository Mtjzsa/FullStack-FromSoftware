import { Component, OnInit } from '@angular/core';
import { Game } from '../_models/game';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-stats',
  templateUrl: './stats.component.html',
  styleUrls: ['./stats.component.scss']
})
export class StatsComponent implements OnInit {
  http: HttpClient
  games: Array<Game>;

  constructor(http: HttpClient) {
    this.http = http
    this.games = []
  }

  ngOnInit(): void {
    this.http.get<Array<Game>>('http://localhost:5146/Game')
      .subscribe(resp => {
        this.games = resp.map(x => Object.assign(new Game(), x));
      });
  }

}
