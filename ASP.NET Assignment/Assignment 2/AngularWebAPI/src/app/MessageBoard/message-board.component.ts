import { Component, OnInit } from '@angular/core';
import { MessageBoardService } from '../shared/message-board.service';
import { PostMessage } from '../shared/post-message.model';
import { HttpClient } from '@angular/common/http';
import { Router} from '@angular/router';
@Component({
  selector: 'app-message-board',
  templateUrl: './message-board.component.html',
  styleUrls: ['./message-board.component.css']
})
export class MessageBoardComponent implements OnInit {
  listData: PostMessage[];
  constructor(private service: MessageBoardService,
    private http: HttpClient,
    private router:Router) { }

  ngOnInit() {

    this.service.getPost()
      .subscribe(data => {
        this.listData = data as PostMessage[];
        console.log(this.listData);
      }); 
  }

  addLike(id:number)
  {
    this.service.addLike(id).subscribe(data=>location.reload());
  }

  addcmt(id:number)
  {
    
      this.router.navigate(['add-comment',id]);
  }






}
