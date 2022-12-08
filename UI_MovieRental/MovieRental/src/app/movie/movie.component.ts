import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterLinkActive } from '@angular/router';
import { AuthService } from '../services/auth.service';
import { MovieServices } from '../services/movie.services';
import { Movie } from './movie.module';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css'],
})
export class MovieComponent implements OnInit {
  movieList: Array<Movie> = [];
  
  isAdmin:boolean = this.auth.isAdmin(); 

  constructor(
    private movieServices: MovieServices,
    private router: Router,
    private auth:AuthService
  ) {}

  selectedMovie!: Movie;

  ngOnInit(): void {
    this.movieServices.getAllMovies().subscribe(
      (data) => {
        this.movieList = data;
      },
      () => {
        this.router.navigate(['server-error']);
      }
    );
  }
  getSelectedMovie(movie: Movie) {
    this.selectedMovie = movie;
    console.log(this.selectedMovie);
  }
}
