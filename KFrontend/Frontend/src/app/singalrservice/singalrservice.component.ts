import { Component } from '@angular/core';
import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

@Component({
  selector: 'app-singalrservice',
  templateUrl: './singalrservice.component.html',
  styleUrls: ['./singalrservice.component.scss']
})
export class SingalrserviceComponent {
  private hubConnection: signalR.HubConnection;

  //AddBoss
  private addBoss = new BehaviorSubject<any>(null);
  addBoss$ = this.addBoss.asObservable();
  
  private addDefeatedBoss = new BehaviorSubject<any>(null);
  addDefeatedBoss$ = this.addDefeatedBoss.asObservable();

  private deleteBoss = new BehaviorSubject<any>(null);
  deleteBoss$ = this.deleteBoss.asObservable();

  private editBoss = new BehaviorSubject<any>(null);
  editBoss$ = this.editBoss.asObservable();


  constructor() {
      this.hubConnection = new signalR.HubConnectionBuilder()
          .withUrl('http://localhost:5146/notificationHub', {
              withCredentials: true
          })
          .build();

      this.hubConnection.start().catch(err => console.error(err));

      this.hubConnection.on('AddBoss', (item) => {
          this.addBoss.next(item);
      });

      this.hubConnection.on('AddDefeatedBoss', (item) => {
        this.addDefeatedBoss.next(item);
      });

      this.hubConnection.on('DeleteBoss', (item) => {
        this.deleteBoss.next(item);
      });

  }
}

