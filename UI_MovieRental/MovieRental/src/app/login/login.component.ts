
import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  @ViewChild('f') formData!: NgForm;

  constructor(private _authServices: AuthService,private router:Router) {}

  isLoading: boolean = false;
  errorMessage: string  = "";

  ngOnInit(): void {}

  loginUser() {
    this.isLoading = true;
    const userValues = this.formData.value;

    this._authServices
      .LoginUser(userValues.username, userValues.password)
      .subscribe(

        (response) => {
          
          this.errorMessage = "";
          
          let user = JSON.parse(atob(response.split('.')[1]));
        
          
          localStorage.setItem('auth token',response);
          localStorage.setItem ('user role',user.role)
          localStorage.setItem ('fullName',user.userFullName)
          
          this.router.navigate(['movie']);
          this.isLoading = false;
        },
        (err) => {
          this.errorMessage = err.error;
          this.isLoading = false;
        }
      );
  }
}
