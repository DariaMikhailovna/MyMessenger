import { Component, OnInit } from '@angular/core';
import {MessagesService} from '../../servises/messagesServise/messages.service';

@Component({
  selector: 'app-list-messages',
  templateUrl: './list-messages.component.html',
  styleUrls: ['./list-messages.component.css']
})
export class ListMessagesComponent implements OnInit {
  message: string[];
  constructor(private messagesService: MessagesService) { }

  ngOnInit() {
    this.getMessages();
  }
  getMessages() {
    this.messagesService
      .getMessanges()
      .subscribe(x => {
        this.message = x;
      });
  }
}
