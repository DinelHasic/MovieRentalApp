import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MovieServices } from 'src/app/services/movie.services';
import { MovieDetails } from '../movie-view-models/movieDetails.model';
import { Genre } from '../genre.enum';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css'],
})
export class MovieDetailsComponent implements OnInit {

  constructor(
    private movieServices: MovieServices,
    private route: ActivatedRoute
  ) {}

  movie!: MovieDetails;

  ngOnInit(): void {
    let id: number = this.route.snapshot.params['id'];
    this.movieServices.getMovieById(id).subscribe((data) => {
      this.movie = data;
    });
  }
}
