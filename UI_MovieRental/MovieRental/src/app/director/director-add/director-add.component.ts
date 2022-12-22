import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { DirectorServices } from 'src/app/services/director.services';

@Component({
  selector: 'app-director-add',
  templateUrl: './director-add.component.html',
  styleUrls: ['./director-add.component.css']
})
export class DirectorAddComponent implements OnInit {

  @ViewChild('f') objectForm!:NgForm; 
  constructor(private directorServices:DirectorServices,private router:Router) { }

  isLoading:boolean = false;

  ngOnInit(): void {
  }


  addDirector()
  {

    this.isLoading = true;
    const value = this.objectForm.value;
    this.directorServices.AddDirector(value).subscribe( (data) => {

      this.isLoading = false;
    },
    (err) => {
      this.router.navigate(['server-error'])
      this.isLoading = false;
    });
  }

}
