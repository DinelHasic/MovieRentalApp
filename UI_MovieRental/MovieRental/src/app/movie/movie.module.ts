import { Genre } from './genre.enum';

export class Movie {
  public id!: number;

  public title!: string;

  public description!: string;

  public genre!: Genre;

  public year!: Date;

  public imageUrl!: string;

  constructor(
    title: string,
    description: string,
    year: Date,
    genre: Genre,
    imageUrl: string
  ) {
    this.title = title;
    this.description = description;
    this.genre = genre;
    this.year = year;
    this.imageUrl = imageUrl;
  }
}
