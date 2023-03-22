import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BestiaryComponent } from './components/bestiary/bestiary.component';

const routes: Routes = [
  { path: 'bestiary', component: BestiaryComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
