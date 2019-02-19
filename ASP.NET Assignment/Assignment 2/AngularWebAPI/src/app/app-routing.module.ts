import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {MessageBoardAddPostComponent} from './MessageBoard/message-board-add-post.component'
import {MessageBoardComponent } from './MessageBoard/message-board.component';
import { MessageBoardAddCommentComponent } from './MessageBoard/message-board-add-comment.component';

const routes: Routes = [
  {path:'add-post', component:MessageBoardAddPostComponent},
  { path:'message-board', component:MessageBoardComponent },
  { path:'add-comment', component:MessageBoardAddCommentComponent },
  { path:'add-comment/:id', component:MessageBoardAddCommentComponent },

  {path:'**',redirectTo:'/message-board',pathMatch:'full'},
 {path:'',redirectTo:'/message-board',pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
