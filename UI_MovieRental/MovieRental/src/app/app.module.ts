import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { MovieComponent } from './movie/movie.component';
import { MovieListComponent } from './movie/movie-list/movie-list.component';
import { HeaderComponent } from './header/header.component';
import { LoginComponent } from './login/login.component';
import { FavoriteListComponent } from './favorite-list/favorite-list.component';
import { FavoriteEditComponent } from './favorite-list/favorite-edit/favorite-edit.component';
import { BackgroundColorGreenDirective } from './basic-hightlight-directives/background-green-directive';
import { MovieAddComponent } from './movie/movie-add/movie-add.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MovieDetailsComponent } from './movie/movie-details/movie-details.component';
import { NotFoundComponent } from './error/not-found/not-found.component';
import { GenrePipe } from './custom-pipes/genre.pipe';
import { ServerErrorComponent } from './error/server-error/server-error.component';
import { TokenInterceptorService } from './token-interceptor.service';
import { LoginSpinerComponent } from './shered/login-spiner/login-spiner.component';
import { RegisterComponent } from './register/register.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { DirectorComponent } from './director/director.component';
import { DirectorAddComponent } from './director/director-add/director-add.component';


@NgModule({
  declarations: [
    AppComponent,
    MovieComponent,
    MovieListComponent,
    MovieAddComponent,
    MovieDetailsComponent,
    HeaderComponent,
    LoginComponent,
    FavoriteListComponent,
    FavoriteEditComponent,
    BackgroundColorGreenDirective,
    NotFoundComponent,
    GenrePipe,
    ServerErrorComponent,
    LoginSpinerComponent,
    RegisterComponent,
    DirectorComponent,
    DirectorAddComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NoopAnimationsModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptorService,
      multi: true,
    },
  ],
  bootstrap: [AppComponent],
})
export class AppModule 
{}
