import { Genre } from './genre.module';

export class Movie {
  public id!: number;

  public title!: string;

  public description!: string;

  public genres!: Array<Genre>;

  public year!: Date;

  public imageUrl!: string;

  constructor(
    title: string,
    description: string,
    year: Date,
    genres: Array<Genre>,
    imageUrl: string
  ) {
    this.title = title;
    this.description = description;
    this.genres = genres;
    this.year = year;
    this.imageUrl = imageUrl;
  }
}
