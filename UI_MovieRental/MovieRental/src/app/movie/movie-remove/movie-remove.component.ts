import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterLinkActive } from '@angular/router';
import { MovieServices } from 'src/app/services/movie.services';
import { UserServices } from 'src/app/services/user.services';

@Component({
  selector: 'app-movie-remove',
  templateUrl: './movie-remove.component.html',
  styleUrls: ['./movie-remove.component.css'],
})
export class MovieRemoveComponent implements OnInit {

  
  constructor(
    private movieServices: MovieServices,
    private router: Router,
    private routeActive: ActivatedRoute
  ) {}

  ngOnInit(): void {}

  deleteMovie() {
    const id = this.routeActive.snapshot.params['id'];
 

    this.movieServices.removeMovie(id).subscribe(
      () => {
        this.router.navigate(['movie']);
      },
      (err) => {
        console.log(err);
        this.router.navigate(['server-error']);
      }
    );
  }

  exitDelete() {
    this.router.navigate(['movie']);
  }
}
