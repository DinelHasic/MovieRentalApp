import {  FormControl, FormGroup,Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { CustomValidator } from '../validators/custom-validator';
import { Router } from '@angular/router';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  registerFrom!: FormGroup;
 
  isLoading:boolean = false;
  

  constructor(private _authServices: AuthService,private router:Router) {}

  ngOnInit(): void {
    this.registerFrom = new FormGroup({
      firstName: new FormControl(null,[Validators.required,Validators.minLength(3)]),
      lastName: new FormControl(null,[Validators.required,Validators.minLength(3)]),
      userName: new FormControl(null,[Validators.required,Validators.minLength(5),CustomValidator.ValidateUsername]),
      password: new FormControl(null,[Validators.required]),
    });
  }

  registerSubmit() {

    this.isLoading = true;
    
    let values = this.registerFrom.value;

    this._authServices.registerUser(values).subscribe(
      (res) => {
        this.router.navigate(["login"]);
        this.isLoading = false;
      },
      (error) => {
          this.router.navigate(["server-error"]);
          this.isLoading = false;
      }
    ) 
  }
}
