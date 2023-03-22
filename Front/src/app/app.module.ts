import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatIconModule } from '@angular/material/icon'
import { BestiaryModule } from './components/bestiary/bestiary.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    BestiaryModule
  ],
  providers: [],
  bootstrap: [
    AppComponent,
  ]
})

export class AppModule { }
