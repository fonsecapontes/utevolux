import { Component, OnInit } from '@angular/core';
import { CreatureService } from 'src/app/services/creature.service';

@Component({
    selector: 'app-bestiary',
    templateUrl: './bestiary.component.html',
})
export class BestiaryComponent implements OnInit {
    creatures = new Array<any>();

    creatureClass = new Map([
        [1, 'amphibic'],
        [2, 'aquatic'],
        [3, 'bird'],
        [4, 'construct'],
        [5, 'magicalCreatures'],
        [6, 'demon'],
        [7, 'dragon'],
        [8, 'elemental'],
        [9, 'extraDimensional'],
        [10, 'fey'],
        [11, 'giant'],
        [12, 'human'],
        [13, 'humanoid'],
        [14, 'lycanthrope'],
        [15, 'mamal'],
        [16, 'undead'],
        [17, 'plant'],
        [18, 'reptile'],
        [19, 'slime'],
        [20, 'vermin'],
        ]);

    constructor(private creatureService: CreatureService) {

    }

    ngOnInit(): void {
        this.creatureService.getCreatures().subscribe((res: any) => {
            this.creatures = res;
        })
    }

    getImage(creature: any) {
        return "/assets/images/creatures/" + this.creatureClass.get(creature.class) + "/" + creature.image;
    }
}
