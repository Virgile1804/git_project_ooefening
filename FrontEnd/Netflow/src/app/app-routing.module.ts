import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './error-pages/not-found/not-found.component';


const routes: Routes = [
  {
    path: '',
    component : ShellComponent,
    children: [{
      path: '',
      pathMatch: 'full',
      redirectTo: '/dashboard'
    },
    {
      path: 'customers',
      loadChildren: () =>
        import('./actor/actor.module').then((m) => m.CustomerModule),
    },
    {
      path: 'dashboard',
      loadChildren: () =>
        import('./episode/episode.module').then((m) => m.DashboardModule),
    },
    {
      path: 'about',
      loadChildren: () =>
        import('./movie/movie.module').then((m) => m.AboutModule),
    },
  ],

  
  },
  {
    path: '**',
    component: NotFoundComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
