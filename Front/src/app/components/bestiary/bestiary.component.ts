import { Component, OnInit } from '@angular/core';
import { CreatureService } from 'src/app/services/creature.service';

@Component({
    selector: 'app-bestiary',
    templateUrl: './bestiary.component.html',
})
export class BestiaryComponent implements OnInit {
    creatures = new Array<any>();

    constructor(private creatureService: CreatureService) {

    }

    ngOnInit(): void {
        this.creatureService.get().subscribe((res: any) => {
            console.log(res);

            this.creatures = res;
        })
    }
}
