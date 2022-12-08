import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login-spiner',
  template: '<div class="lds-ring"><div></div><div></div><div></div><div></div></div>',
  styleUrls: ['./login-spiner.component.css']
})
export class LoginSpinerComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
