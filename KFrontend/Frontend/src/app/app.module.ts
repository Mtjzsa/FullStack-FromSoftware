import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { LogoutComponent } from './logout/logout.component';
import { RegisterComponent } from './register/register.component';
import { ListGamesComponent } from './list-games/list-games.component';
import { ListBossesComponent } from './list-bosses/list-bosses.component';
import { FooterComponent } from './footer/footer.component';
import { NavigationComponent } from './navigation/navigation.component';
import { ViewBossComponent } from './view-boss/view-boss.component';
import { ViewGamesComponent } from './view-games/view-games.component';
import { CreateBossComponent } from './create-boss/create-boss.component';
import { CreateGameComponent } from './create-game/create-game.component';
import { UpdateDeleteBossComponent } from './update-delete-boss/update-delete-boss.component';
import { UpdateDeleteGameComponent } from './update-delete-game/update-delete-game.component';
import { ProfileComponent } from './profile/profile.component';
import { ProgressComponent } from './progress/progress.component';
import { StatsComponent } from './stats/stats.component';
import { NgChartsModule } from 'ng2-charts';

//form
import {MatFormFieldModule} from '@angular/material/form-field';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input'
import { MatCheckboxModule } from '@angular/material/checkbox'

//material designs
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatDividerModule } from '@angular/material/divider';
import {MatIconModule} from '@angular/material/icon';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import {MatSelectModule} from '@angular/material/select';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatListModule } from '@angular/material/list';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatTooltipModule } from '@angular/material/tooltip';
import { SingalrserviceComponent } from './singalrservice/singalrservice.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    LogoutComponent,
    RegisterComponent,
    ListGamesComponent,
    ListBossesComponent,
    FooterComponent,
    NavigationComponent,
    ViewBossComponent,
    ViewGamesComponent,
    CreateBossComponent,
    CreateGameComponent,
    UpdateDeleteBossComponent,
    UpdateDeleteGameComponent,
    ProfileComponent,
    ProgressComponent,
    StatsComponent,
    SingalrserviceComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSlideToggleModule,
    MatIconModule,
    MatDividerModule,
    MatMenuModule,
    MatButtonModule,
    HttpClientModule,
    MatCardModule,
    MatSnackBarModule,
    MatFormFieldModule,
    FormsModule,
    ReactiveFormsModule,
    MatInputModule,
    MatCheckboxModule,
    MatSelectModule,
    NgChartsModule,
    MatToolbarModule,
    MatListModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatTooltipModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
