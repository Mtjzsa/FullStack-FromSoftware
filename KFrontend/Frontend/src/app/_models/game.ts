import { Boss } from "./boss"

export class Game {
  public id : number = 0
  public gameName : string = ""
  public releaseDate : number = 0
  public gameCover : string = ""
  public bosses : Array<Boss> = []
  public gameDescription : string = ""

  public createBosses(bossList : Array<Boss>){
    
  }
}