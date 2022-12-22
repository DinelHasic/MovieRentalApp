import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Movie } from '../movie.module';
import { MovieServices } from 'src/app/services/movie.services';
import { DirectorServices } from 'src/app/services/director.services';
import { Router } from '@angular/router';
import { DirectorDetails } from '../../Interfaces/directorDetails.interface';
import { GenreServices } from 'src/app/services/genre.service';
import { Genre } from '../genre.module';
import { NewMovie } from 'src/app/Interfaces/newMovie.interface';

@Component({
  selector: 'app-movie-add',
  templateUrl: './movie-add.component.html',
  styleUrls: ['./movie-add.component.css'],
})
export class MovieAddComponent implements OnInit {
  @ViewChild('f') formObject!: NgForm;

  movie!: Movie;

  directorsData!: Array<DirectorDetails>;

  genresData!: Array<Genre>;

  isLoading: boolean = false;

  constructor(
    private movieServices: MovieServices,
    private router: Router,
    private directorServices: DirectorServices,
    private genreServices: GenreServices
  ) {}

  ngOnInit(): void {

    this.directorServices.GetAllDirectors().subscribe(
      (data) => {
        this.directorsData = data;
      },
      () => {
        this.router.navigate(['server-error']);
      }
    );

    this.genreServices.GetAllGenres().subscribe(
      (data) => {
        this.genresData = data;
        console.log(this.genresData);
      },
      () => {
        this.router.navigate(['server-error']);
      }
    );
  }

  addMovie() {
    this.isLoading = true;
    let newMovie: NewMovie = this.formObject.value;

    this.movieServices.addNewMovie(newMovie).subscribe(
      (data) => {
        this.isLoading = false;
        this.router.navigate(['movie']);
      },
      () => {
        this.isLoading = false;

        this.router.navigate(['server-error']);
      }
    );
  }
}
