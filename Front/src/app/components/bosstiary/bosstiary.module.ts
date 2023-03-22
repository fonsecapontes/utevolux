import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BosstiaryComponent } from './bosstiary.component';
import { MatSliderModule } from '@angular/material/slider';
import { CreatureService } from 'src/app/services/creature.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    BosstiaryComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    MatSliderModule
  ],
  providers: [CreatureService],
})

export class BosstiaryModule { }
