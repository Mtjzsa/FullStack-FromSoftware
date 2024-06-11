import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { LogoutComponent } from './logout/logout.component';
import { RegisterComponent } from './register/register.component';
import { ListBossesComponent } from './list-bosses/list-bosses.component';
import { ListGamesComponent } from './list-games/list-games.component';
import { ViewBossComponent } from './view-boss/view-boss.component';
import { ApiService } from './api.service';
import { ViewGamesComponent } from './view-games/view-games.component';
import { CreateBossComponent } from './create-boss/create-boss.component';
import { CreateGameComponent } from './create-game/create-game.component';
import { UpdateDeleteGameComponent } from './update-delete-game/update-delete-game.component';
import { UpdateDeleteBossComponent } from './update-delete-boss/update-delete-boss.component';
import { ProfileComponent } from './profile/profile.component';
import { ProgressComponent } from './progress/progress.component';
import { StatsComponent } from './stats/stats.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent},
  { path: 'login', component: LoginComponent},
  { path: 'logout', component: LogoutComponent},
  { path: 'register', component: RegisterComponent},
  { path: 'list-bosses', component: ListBossesComponent},
  { path: 'list-games', component: ListGamesComponent},

  {path: "view-boss/:bossName", component: ViewBossComponent, canActivate: [ApiService]},
  {path: "view-game/:gameName", component: ViewGamesComponent, canActivate: [ApiService]},

  {path: "updatedelete-boss/:bossName", component: UpdateDeleteBossComponent, canActivate: [ApiService]},
  {path: "updatedelete-game/:gameName", component: UpdateDeleteGameComponent, canActivate: [ApiService]},

  {path: "create-boss", component: CreateBossComponent, canActivate: [ApiService]},
  {path: "create-game", component: CreateGameComponent, canActivate: [ApiService]},

  {path: "profile", component: ProfileComponent, canActivate: [ApiService]},
  {path: "progress", component: ProgressComponent, canActivate: [ApiService]},
  {path: "statistics", component: StatsComponent, canActivate: [ApiService]},

  { path: '**',  redirectTo: 'home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
