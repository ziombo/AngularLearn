import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class FeatureService {

  constructor(private htpp: Http) { }

  getFeatures(){
    return this.htpp.get("/api/makes")
      .map(res => res.json());
  }
}
