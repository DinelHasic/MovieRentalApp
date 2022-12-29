import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RatingCreate } from '../Interfaces/ratingCreateInterface';

@Injectable({
  providedIn: 'root',
})
export class RatingServices {
  constructor(private _http: HttpClient) {}

  AddRating(rating: RatingCreate) {
   return this._http.post('https://localhost:7025/api/Rating/rating/add', rating);
  }
}
