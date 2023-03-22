import { Component } from '@angular/core';

@Component({
    selector: 'app-bestiary',
    templateUrl: './bestiary.component.html',
})
export class BestiaryComponent {
    creatures = [
        { name: 'Acid blob', img: 'https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif' },
        { name: 'Acolytes Of The Cult', img: 'https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif' },
        { name: 'Adepts Of The Cult', img: 'https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif' },
    ]
}
