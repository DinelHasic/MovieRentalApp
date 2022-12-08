import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Movie } from '../movie.module';
import { MovieServices } from 'src/app/services/movie.services';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-movie-add',
  templateUrl: './movie-add.component.html',
  styleUrls: ['./movie-add.component.css'],
})
export class MovieAddComponent implements OnInit {
  @ViewChild('f') formObject!: NgForm;

  movie!: Movie;
  constructor(private movieServices: MovieServices, private router: Router) {}

  ngOnInit(): void {}

  addMovie() {
    let data = this.formObject.value;

    const movie = new Movie(
      data.title,
      data.description,
      data.year,
      parseInt(data.genre),
      data.imageUrl
    );

    this.movieServices.addNewMovie(movie).subscribe((data) => {
    console.log(data)
    });
    

    this.router.navigate(['movie']);
  }
}
