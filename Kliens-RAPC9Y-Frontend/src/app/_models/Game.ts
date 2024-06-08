import { Boss } from "./Boss"

export class Game{
  public id : number = 0
  public gameName : string = ""
  public releaseDate : number = 0
  public gameCover : string = ""

  public bosses : Array<Boss> = []
}