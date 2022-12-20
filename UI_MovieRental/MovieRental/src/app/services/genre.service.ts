import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Genre } from '../movie/genre.module';

@Injectable({
  providedIn: 'root'
})
export class GenreServices{

  constructor(private _http:HttpClient) { }



  GetAllGenres() :Observable<Array<Genre>>
  {
    return this._http.get<Array<Genre>>("https://localhost:7025/api/Genre/genre/all");
  }
}
