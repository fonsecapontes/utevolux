import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BestiaryComponent } from './bestiary.component';
import { MatSliderModule } from '@angular/material/slider';

@NgModule({
  declarations: [
    BestiaryComponent
  ],
  imports: [
    BrowserModule,
    MatSliderModule
  ],
  providers: [],
})

export class BestiaryModule { }
