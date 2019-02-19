import { Component, OnInit } from '@angular/core';
import { MessageBoardService } from '../shared/message-board.service';
import {PostMessage} from '../shared/post-message.model';
import { NgForm } from '@angular/forms';
import {Router } from '@angular/router';

@Component({
  selector: 'app-message-board-add-post',
  templateUrl: './message-board-add-post.component.html',
  styleUrls: ['./message-board-add-post.component.css']
})
export class MessageBoardAddPostComponent implements OnInit {

  constructor(private service:MessageBoardService,
      private router:Router) { }
  postMessage:PostMessage;
  ngOnInit() {
    this.postMessage=new PostMessage();
  }
  savePost()
  {
     this.service.addPost(this.postMessage).subscribe();
     this.router.navigate(['message-board']);
  }

  
}
