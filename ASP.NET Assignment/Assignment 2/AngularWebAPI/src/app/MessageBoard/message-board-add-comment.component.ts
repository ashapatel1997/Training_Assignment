import { Component, OnInit } from '@angular/core';
import {Router,ActivatedRoute} from '@angular/router';
import {MessageBoardService} from '../shared/message-board.service'
import { CommentMessage } from '../shared/comment-message.model';
import { PostMessage } from '../shared/post-message.model';
@Component({
  selector: 'app-message-board-add-comment',
  templateUrl: './message-board-add-comment.component.html',
  styleUrls: ['../app.component.css']
})
export class MessageBoardAddCommentComponent implements OnInit {

  constructor(private router:Router,
    private route:ActivatedRoute,
    private service:MessageBoardService) { }
    commentAdd:CommentMessage;
    postMessage:PostMessage;
  ngOnInit() {
    this.commentAdd=new CommentMessage();
    this.postMessage=new PostMessage();
    const id: number = parseInt(this.route.snapshot.paramMap.get('id'));
    this.service.getPostById(id).subscribe(data => this.postMessage = data as PostMessage);
    
  }
 
  saveComment(id:number){
   
    this.service.addComment(this.commentAdd, id).subscribe();
    
    this.router.navigate(['message-board']);
  }

}
