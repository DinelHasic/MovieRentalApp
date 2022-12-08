import { Component, ElementRef, OnInit,ViewChild ,Output,EventEmitter} from '@angular/core';
import { FavoriteMoviesServices } from 'src/app/services/favoriteMovies.Services';
import { FavoriteMovie } from '../favoriteMovie.module';

@Component({
  selector: 'app-favorite-edit',
  templateUrl: './favorite-edit.component.html',
  styleUrls: ['./favorite-edit.component.css']
})
export class FavoriteEditComponent implements OnInit {

  @ViewChild('inputMovieFavorite') nameInput!:ElementRef;
  @ViewChild('inputRating') ratingInput!:ElementRef;
  

  constructor(private _favoriteMovieService:FavoriteMoviesServices) { }

  ngOnInit(): void {
  }

  addInputtedValues()
  {
    const ingName:string = this.nameInput.nativeElement.value;
    const ingRating:number = this.ratingInput.nativeElement.value;

    if(ingName !== "" && ingRating !== 0)
    {
      const favoriteMovie = new FavoriteMovie(ingName,ingRating)
      this._favoriteMovieService.insertFavoriteMovie(favoriteMovie);
    }


    this.nameInput.nativeElement.value = "";
    this.ratingInput.nativeElement.value = "";

  }
}
