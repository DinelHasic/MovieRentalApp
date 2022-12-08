import {
  Component,
  Input,
  Output,
  OnInit,
  EventEmitter,
} from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

import { Movie } from '../movie.module';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css'],
})
export class MovieListComponent implements OnInit {
  @Input() movies: Array<Movie> = [];

  @Output() selectMovie = new EventEmitter<Movie>();

  isAdmin = this.auth.isAdmin();

  isRemove:boolean = false;
  constructor(private auth: AuthService,private router:Router) {}

  ngOnInit(): void {}

  getMovieDetails(movie: Movie) {
    this.selectMovie.emit(movie);
  }

  showDialog(movieId:number)
  {
    this.router.navigate(['remove'],{queryParams:{id:movieId}})
    
  }
}
