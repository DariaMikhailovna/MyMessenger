import { Component, OnInit } from '@angular/core';
import {MessagesService} from '../../servises/messagesServise/messages.service';

@Component({
  selector: 'app-list-messages',
  templateUrl: './list-messages.component.html',
  styleUrls: ['./list-messages.component.css']
})
export class ListMessagesComponent implements OnInit {
  messages: string[] = [];
  constructor(private messagesService: MessagesService) { }

  ngOnInit() {
    const ws = new WebSocket('ws://localhost:49899/ws');
    ws.onmessage = (event) => {
      this.messages.push(event.data);
      console.log(this.messages);
    };
  }
}
