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

const routes: Routes = [
  { path: 'home', component: HomeComponent},
  { path: 'login', component: LoginComponent},
  { path: 'logout', component: LogoutComponent},
  { path: 'register', component: RegisterComponent},
  { path: 'list-bosses', component: ListBossesComponent},
  { path: 'list-games', component: ListGamesComponent},

  {path: "view-boss/:bossName", component: ViewBossComponent, canActivate: [ApiService]},
  {path: "view-game/:gameName", component: ViewGamesComponent, canActivate: [ApiService]},

  { path: '**',  redirectTo: 'home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
