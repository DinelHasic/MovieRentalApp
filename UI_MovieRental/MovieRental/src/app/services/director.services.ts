import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DirectorDetails } from '../Interfaces/directorDetails.interface';
import { DirectorNew } from '../Interfaces/directorNew.interface';
import { Director } from '../movie/movie-view-models/director.model';

@Injectable({
  providedIn: 'root',
})
export class DirectorServices {
  constructor(private _http: HttpClient) {}

  GetAllDirectors(): Observable<Array<DirectorDetails>> {
    return this._http.get<Array<DirectorDetails>>(
      'https://localhost:7025/api/Director/directors/all'
    );
  }

  AddDirector(director:DirectorNew): Observable<Director>
  {
    return this._http.post<Director>("https://localhost:7025/api/Director/director/create",director);
  }
}
