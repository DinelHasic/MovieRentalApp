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
        console.log(this.directorsData);
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
    let newMovie: NewMovie = this.formObject.value;

    console.log(newMovie);

    this.movieServices.addNewMovie(newMovie).subscribe((data) => {
      console.log(data);
    });

    this.router.navigate(['movie']);
  }
}
