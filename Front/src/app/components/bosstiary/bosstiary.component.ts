import { Component, OnInit } from '@angular/core';
import { CreatureService } from 'src/app/services/creature.service';

@Component({
    selector: 'app-bosstiary',
    templateUrl: './bosstiary.component.html',
})
export class BosstiaryComponent implements OnInit {
    creatures = new Array<any>();

    constructor(private creatureService: CreatureService) {

    }

    ngOnInit(): void {
        this.creatureService.getBosses().subscribe((res: any) => {
            this.creatures = res;
        })
    }

    getImage(creature: any) {
        return "/assets/images/creatures/bosses/" + creature.image;
    }
}
