import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ActorComponent } from './actor/actor.component';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EpisodeComponent } from './episode/episode.component';
import { MovieComponent } from './movie/movie.component';

@NgModule({
  declarations: [
    AppComponent,
    EpisodeComponent,
    MovieComponent,
    ActorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    
  ],
  
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
