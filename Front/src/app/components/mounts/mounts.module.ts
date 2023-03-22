import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MountsComponent } from './mounts.component';
import { MatSliderModule } from '@angular/material/slider';
import { HttpClientModule } from '@angular/common/http';
import { MountsService } from 'src/app/services/mounts.service';

@NgModule({
  declarations: [
    MountsComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    MatSliderModule
  ],
  providers: [MountsService],
})

export class MountsModule { }
