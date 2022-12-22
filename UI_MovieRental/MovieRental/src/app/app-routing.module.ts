import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FavoriteListComponent } from './favorite-list/favorite-list.component';
import { LoginComponent } from './login/login.component';
import { MovieComponent } from './movie/movie.component';
import { MovieAddComponent } from './movie/movie-add/movie-add.component';
import { MovieDetailsComponent } from './movie/movie-details/movie-details.component';
import { NotFoundComponent } from './error/not-found/not-found.component';
import { ServerErrorComponent } from './error/server-error/server-error.component';
import { LoginGuard } from './guards/login.guard';
import { RegisterComponent } from './register/register.component';
import { RoleGuard } from './guards/role.guard';
import { MovieRemoveComponent } from './movie/movie-remove/movie-remove.component';
import { DirectorAddComponent } from './director/director-add/director-add.component';
const routes: Routes = [
  { path: 'movie', component: MovieComponent },
  { path: 'movie/details/:id', component: MovieDetailsComponent,canActivate:[LoginGuard] },
  { path: 'movie/remove/:id', component:MovieRemoveComponent,canActivate:[RoleGuard]},
  { path: 'director/add', component:DirectorAddComponent,canActivate:[RoleGuard]},
  { path: 'login', component: LoginComponent },
  { path: 'register',component:RegisterComponent},
  { path: 'favorite', component: FavoriteListComponent,canActivate:[LoginGuard]},
  { path: 'movie/create', component: MovieAddComponent,canActivate:[RoleGuard] },
  { path: '', redirectTo: '/movie', pathMatch: 'full' },
  { path: 'not-found', component: NotFoundComponent },
  { path: 'server-error', component: ServerErrorComponent },
  { path: '**', redirectTo: 'not-found', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
