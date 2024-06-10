import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Boss } from '../_models/boss';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Game } from '../_models/game';

@Component({
  selector: 'app-update-delete-boss',
  templateUrl: './update-delete-boss.component.html',
  styleUrls: ['./update-delete-boss.component.scss']
})
export class UpdateDeleteBossComponent implements OnInit{
  http: HttpClient
  route: ActivatedRoute
  boss: Boss
  games : Array<Game>
  snackbar: MatSnackBar
  deleteDisabled: boolean

  constructor(http: HttpClient, route: ActivatedRoute, snackBar: MatSnackBar){
    this.http = http
    this.route = route
    this.boss= new Boss()
    this.games = []
    this.snackbar = snackBar
    this.deleteDisabled = true
  }
  ngOnInit(): void {
    this.route.params.subscribe(param =>{
      let bossName = param["bossName"]
      let headers = new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
      })
      this.http
        .get<any>('http://localhost:5146/Boss/' + bossName, {headers: headers})
        .subscribe(resp =>{
            this.boss.id = resp.id
          this.boss.bossName = resp.bossName
          this.boss.game_Id = resp.game_Id
          this.boss.defense = resp.defense
          this.boss.hp = resp.hp
          this.boss.image = resp.image
          this.boss.location = resp.location
          this.boss.souls = resp.souls
          this.boss.description = resp.description
          })

          console.log(this.boss)
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

  public updateBoss() : void{

  }

  public deleteBoss(bossName : string) : void {

  }
}
