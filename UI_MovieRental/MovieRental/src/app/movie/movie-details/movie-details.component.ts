import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MovieServices } from 'src/app/services/movie.services';
import { MovieDetails } from '../movie-view-models/movieDetails.model';
import { RatingServices } from 'src/app/services/rating.services';
import { NgForm } from '@angular/forms';
import { RatingCreate } from '../../Interfaces/ratingCreateInterface';


@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css'],
})
export class MovieDetailsComponent implements OnInit {
  constructor(
    private movieServices: MovieServices,
    private route: ActivatedRoute,
    private ratingServices:RatingServices,
  ) {}

  @ViewChild('f') formObject!: NgForm;

  movie!: MovieDetails;
  id!:number;

  ngOnInit(): void 
  {
    
    this.id = this.route.snapshot.params['id'];

    this.movieServices.getMovieById(this.id).subscribe((data) => {
      this.movie = data;
      console.log(this.movie);
    });
  }

  submitRating()
  {
  
    const rating:number = this.formObject.value['ratingNumber'];
    const idMovie:number = this.id;

    const newRating:RatingCreate = {ratingNumber:rating, movieId:idMovie}

    this.ratingServices.AddRating(newRating).subscribe(x => {
      console.log(x);
    });

    window.location.reload();
  }
}
