import { Genre } from "../genre.enum";
export class MovieDetails
{
    public title!: string;

    public description!: string;
  
    public genre!: Genre;
  
    public year!: Date;
  
    public imageUrl!: string;
}