import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {FormsModule} from '@angular/forms';
import { MessageBoardComponent } from './MessageBoard/message-board.component';
import { MessageBoardAddPostComponent } from './MessageBoard/message-board-add-post.component';
import { MessageBoardService} from './shared/message-board.service';
import {HttpClientModule} from '@angular/common/http';
import { MessageBoardAddCommentComponent } from './MessageBoard/message-board-add-comment.component';

@NgModule({
  declarations: [
    AppComponent,
    MessageBoardComponent,
    MessageBoardAddPostComponent,
    MessageBoardAddCommentComponent,
    
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
   FormsModule,
   HttpClientModule
  ],
  providers: [MessageBoardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
