import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {

    constructor(http: Http) {
        http.get('/home/test').subscribe(result => {
        });
    }
}