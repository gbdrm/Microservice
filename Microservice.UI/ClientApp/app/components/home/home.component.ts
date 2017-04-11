import { Component } from '@angular/core';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    service: string = null;
    input: string = 'http://127.0.0.1:9000';

    addService = function () {
        this.service = this.input;
    }
}
