import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BestiaryComponent } from './components/bestiary/bestiary.component';
import { BosstiaryComponent } from './components/bosstiary/bosstiary.component';
import { MountsComponent } from './components/mounts/mounts.component';

const routes: Routes = [
  { path: 'bestiary', component: BestiaryComponent },
  { path: 'bosstiary', component: BosstiaryComponent },
  { path: 'mounts', component: MountsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
