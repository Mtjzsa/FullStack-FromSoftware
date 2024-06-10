import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Game } from '../_models/game';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-update-delete-game',
  templateUrl: './update-delete-game.component.html',
  styleUrls: ['./update-delete-game.component.scss']
})
export class UpdateDeleteGameComponent implements OnInit{
  http: HttpClient
  route: ActivatedRoute
  router : Router
  game: Game
  snackbar: MatSnackBar
  deleteDisabled: boolean

  constructor(http: HttpClient, route: ActivatedRoute, snackBar: MatSnackBar, router: Router){
    this.http = http
    this.route = route
    this.router = router
    this.game= new Game()
    this.snackbar = snackBar
    this.deleteDisabled = true
  }

  ngOnInit(): void{
    this.route.params.subscribe(param =>{
      let gameName = param["gameName"]
      let headers = new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
      })
      this.http
        .get<Game>('http://localhost:5146/Game/' + gameName, {headers: headers})
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

  public updateGame() : void {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
    })
    this.http
    .put('http://localhost:5146/Game/',
      this.game,
      { headers: headers}
    )
    .subscribe(
      (success) =>{
        this.snackbar.open("Update was successful!", "Close", {duration: 5000})
        this.router.navigate(['/list-games/',])
      },
      (error)=>{
        this.snackbar.open("Error occured, please try again.", "Close", {duration:5000})
      }
    )
  }

  public deleteGame(gameName : string) : void{
    if (gameName === '' || gameName === null){
      return
    }

    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
    })
    this.http
    .delete(
      'http://localhost:5146/Game/' + gameName,
      { headers: headers}
    )
    .subscribe(
      (success)=>{
        this.snackbar.open("Delete was successful!", "Close", {duration: 5000})
        this.router.navigate(['/list-games'])
      },
      (error)=>{
        this.snackbar.open("Error occured, please try again.", "Close", {duration: 5000})
      }
    )
  }
}
