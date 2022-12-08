
import { Injectable } from "@angular/core";
import { Movie } from "../movie/movie.module";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { MovieDetails } from "../movie/movie-view-models/movieDetails.model";

@Injectable({
    providedIn:'root'
})

export class MovieServices
{
   

  constructor(private _http:HttpClient)
  {
     console.log("It's initialized")
  }

  
   getAllMovies():Observable<Array<Movie>>
   {
      return this._http.get<Array<Movie>>("https://localhost:7025/api/Movie/movie/get/all");
   } 
   
   addNewMovie(movie:Movie)
   {
     return this._http.post("https://localhost:7025/api/Movie/movie/create",movie);
   }

   getMovieById(id:number):Observable<MovieDetails>
   {
     return this._http.get<MovieDetails>(`https://localhost:7025/api/Movie/movie/details/${id}`)
   }

   removeMovie(id:number)
   {
     return this._http.delete(`https://localhost:7025/api/Movie/movie/delete?id=${id}`)
   }


}