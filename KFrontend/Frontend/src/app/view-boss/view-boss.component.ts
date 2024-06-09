import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute } from '@angular/router';
import { Boss } from '../_models/boss';


@Component({
  selector: 'app-view-boss',
  templateUrl: './view-boss.component.html',
  styleUrls: ['./view-boss.component.scss']
})
export class ViewBossComponent implements OnInit{
  
  http: HttpClient
  route: ActivatedRoute
  snackBar:MatSnackBar
  boss : Boss
  deleteDisabled: boolean

  constructor(http: HttpClient, route:ActivatedRoute, snackBar:MatSnackBar) {
    this.http = http
    this.route = route
    this.boss = new Boss()
    this.snackBar = snackBar
    this.deleteDisabled = true
  }
  ngOnInit(): void {
    this.route.params.subscribe(param =>{
      let bossName = param['bossName']
      let headers = new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
      })

      this.http.get<any>('http://localhost:5146/Boss/'+ bossName, {headers: headers})
      .subscribe(resp =>{
          this.boss.id = resp.id
          this.boss.bossName = resp.bossName
          this.boss.game_Id = resp.game_Id
          this.boss.defense = resp.defense
          this.boss.hp = resp.hp
          this.boss.image = resp.image
          this.boss.location = resp.localhost
          this.boss.souls = resp.souls
          this.boss.description = resp.description
      })
        console.log(this.boss)
    })
  }
}
