import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private _http: HttpClient) {}

  LoginUser(userName: string, password: string): Observable<string> {
    return this._http.post(
      'https://localhost:7025/api/User/user/login',
      { userName, password },
      { responseType: 'text' }
    );
  }

  registerUser(registerUser: RegisterUser) {
    return this._http.post(
      'https://localhost:7025/api/User/user/register',
      registerUser
    );
  }

  isLogged() {
    return localStorage.getItem('auth token') != null;
  }

  isAdmin() {
    return localStorage.getItem('user role') == 'Admin';
  }
}

interface RegisterUser {
  userName: string;
  password: string;
  firstName: string;
  lastName: string;
}
