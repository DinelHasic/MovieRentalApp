import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FavoriteMoviesServices } from '../services/favoriteMovies.Services';
import { FavoriteMovie } from './favoriteMovie.module';

@Component({
  selector: 'app-favorite-list',
  templateUrl: './favorite-list.component.html',
  styleUrls: ['./favorite-list.component.css'],
  providers: [FavoriteListComponent]
})
export class FavoriteListComponent implements OnInit {

  
  listFavoriteMovies!:Array<FavoriteMovie>;

  constructor(private _favoriteMovieServices:FavoriteMoviesServices) { }

  ngOnInit(): void {
    this.listFavoriteMovies = this._favoriteMovieServices.getAllFavoriteMovies()
  }
}
