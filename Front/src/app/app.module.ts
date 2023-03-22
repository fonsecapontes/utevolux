import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatIconModule } from '@angular/material/icon'
import { BestiaryModule } from './components/bestiary/bestiary.module';
import { BosstiaryModule } from './components/bosstiary/bosstiary.module';
import { MountsModule } from './components/mounts/mounts.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    BestiaryModule,
    BosstiaryModule,
    MountsModule
  ],
  providers: [],
  bootstrap: [
    AppComponent,
  ]
})

export class AppModule { }
