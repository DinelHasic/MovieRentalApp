import { Injectable } from '@angular/core';
import { FavoriteMovie } from '../favorite-list/favoriteMovie.module';

@Injectable({
  providedIn: 'root',
})
export class FavoriteMoviesServices {
  private readonly _favoriteMovies: Array<FavoriteMovie> = [
    new FavoriteMovie('Simba', 9),
  ];

  constructor() {
    console.log('Hello');
  }

  getAllFavoriteMovies(): Array<FavoriteMovie> {
    return this._favoriteMovies;
  }

  insertFavoriteMovie(fMovie: FavoriteMovie): void {
    this._favoriteMovies.push(fMovie);
  }
}
