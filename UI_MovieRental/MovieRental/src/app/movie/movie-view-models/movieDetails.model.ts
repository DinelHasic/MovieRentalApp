import { Genre } from '../genre.module';
import { Director } from './director.model';

export class MovieDetails {
  public title!: string;

  public description!: string;

  public genres!: Array<Genre>;

  public year!: Date;

  public imageUrl!: string;

  public directors!:Array<Director>
}
