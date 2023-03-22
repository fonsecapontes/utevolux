import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BestiaryComponent } from './bestiary.component';
import { MatSliderModule } from '@angular/material/slider';
import { CreatureService } from 'src/app/services/creature.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    BestiaryComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    MatSliderModule
  ],
  providers: [CreatureService],
})

export class BestiaryModule { }
