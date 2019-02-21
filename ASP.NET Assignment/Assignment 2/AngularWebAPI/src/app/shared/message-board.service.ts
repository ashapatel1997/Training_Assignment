import { Injectable } from '@angular/core';
import { PostMessage } from './post-message.model';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { CommentMessage } from './comment-message.model';
@Injectable({
  providedIn: 'root'
})
export class MessageBoardService {

  postMessage:PostMessage;
  constructor(private http:HttpClient) { }
 
  
  addPost(newPost:PostMessage)
  {
     return this.http.post('http://localhost:54637/api/addPost',newPost);
  }
  getPost()
  {
    return this.http.get('http://localhost:54637/api/allPost');  
  }
  addLike(id:number)
  {
    return this.http.put('http://localhost:54637/api/addLike/'+id,id);
  }
 

  addComment(commentAdd:CommentMessage, id:number)
  {
    
    return this.http.post('http://localhost:54637/api/addComment/'+id,commentAdd);
  }

  getPostById(id:number)
  {
    
    return this.http.get('http://localhost:54637/api/postById/'+id);
  }

  refreshPage()
  {
    this.http.get('http://localhost:54637/api/allPost').toPromise().then(p=>this.postMessage=p as PostMessage);
  }
}
