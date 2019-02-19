import { CommentMessage } from './comment-message.model';

export class PostMessage {
    public Id:number;
    public Message:string;
    public Total_Likes:number;
    public Comment:CommentMessage[];
  
}
