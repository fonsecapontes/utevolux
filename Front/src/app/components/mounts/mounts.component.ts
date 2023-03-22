import { Component, OnInit } from '@angular/core';
import { MountsService } from 'src/app/services/mounts.service';

@Component({
    selector: 'app-mounts',
    templateUrl: './mounts.component.html',
})
export class MountsComponent implements OnInit {
    creatures = new Array<any>();

    constructor(private mountsService: MountsService) {

    }

    ngOnInit(): void {
        this.mountsService.get().subscribe((res: any) => {
            this.creatures = res;
        })
    }
}
