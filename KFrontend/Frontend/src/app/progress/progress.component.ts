import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { AppUser } from '../_models/appuser';
import { ActivatedRoute, Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Boss } from '../_models/boss';
import { Game } from '../_models/game';
import { SingalrserviceComponent } from '../singalrservice/singalrservice.component';

@Component({
  selector: 'app-progress',
  templateUrl: './progress.component.html',
  styleUrls: ['./progress.component.scss']
})
export class ProgressComponent {
  http: HttpClient
  appUser : AppUser
  route: ActivatedRoute
  router : Router
  snackbar: MatSnackBar
  defeated : Array<Boss>
  bosses : Array<Boss>
  games : Array<Game>
  selectedBoss: string;

  constructor(http: HttpClient, route: ActivatedRoute, snackBar: MatSnackBar, router: Router,  private SignalRService : SingalrserviceComponent) {
    this.http = http
    this.appUser = new AppUser
    this.route = route
    this.router = router
    this.snackbar = snackBar
    this.defeated = []
    this.bosses = []
    this.games = []
    this.selectedBoss = ""
  }

  ngOnInit(): void {
    //Get all of the UsersData
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
    })
    this.http.get<AppUser>('http://localhost:5146/Auth/', {headers: headers})
    .subscribe(resp =>{
      this.appUser.userName = resp.userName
      this.appUser.firstName = resp.firstName
      this.appUser.lastName = resp.lastName
      this.appUser.email = resp.email
      this.appUser.defeatedBosses = resp.defeatedBosses
    })
    //Get all of the bosses
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
    //Get all of the Games
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

    this.SignalRService.addDefeatedBoss$.subscribe((bossName)=>{
      if (bossName){
        console.log(bossName)
        this.appUser.defeatedBosses = bossName
      }
    })
    
  }

  public getDefeatedBossesForGame(gameId: number): Array<Boss> {
    const defeatedBossNames = this.appUser.defeatedBosses.split(';');
    return this.bosses.filter(boss => boss.game_Id === gameId && defeatedBossNames.includes(boss.bossName));
  }

  public getUndefeatedBossesByGame(): { [key: string]: Array<Boss> } {
    const defeatedBossNames = this.appUser.defeatedBosses.split(';');
    const undefeatedBosses = this.bosses.filter(boss => !defeatedBossNames.includes(boss.bossName));

    const bossesByGame: { [key: string]: Array<Boss> } = {};
    this.games.forEach(game => {
      bossesByGame[game.gameName] = undefeatedBosses.filter(boss => boss.game_Id === game.id);
    });

    return bossesByGame;
  }

  public addDefeatedBosstoUser(bossName : string, username : string) : void{
    // if (this.selectedBoss){
    // }
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('nikprog-practiceapi-token')
    })
      console.log(this.selectedBoss)
      console.log(localStorage.getItem('nikprog-practiceapi-token'))
      this.http
      .post(
        'http://localhost:5146/Boss/'+ username+'/' + bossName,
        { headers: headers }
      )
      .subscribe(
        (success) => {
          this.snackbar.open('Boss succesfully added to your list!', 'Close', { duration: 5000 })
          //this.router.navigate(['/progress'])
          this.appUser.defeatedBosses += `;${bossName}`
          this.selectedBoss = "";

        },
        (error) => {
          this.snackbar.open('Error occured, please try again.', 'Close', { duration: 5000 })
        }
      )
    
  }


}
