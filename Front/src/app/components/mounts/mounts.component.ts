import { Component, OnInit } from '@angular/core';
import { MountsService } from 'src/app/services/mounts.service';

@Component({
    selector: 'app-mounts',
    templateUrl: './mounts.component.html',
})
export class MountsComponent implements OnInit {
    mounts = new Array<any>();

    constructor(private mountsService: MountsService) {

    }

    ngOnInit(): void {
        this.mountsService.get().subscribe((res: any) => {
            this.mounts = res;
        })
    }

    getImage(mount: any) {
        return "/assets/images/mounts/" + mount.image;
    }
}
