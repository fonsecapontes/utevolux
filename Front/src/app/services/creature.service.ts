import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class CreatureService {
  constructor(private http: HttpClient) { }

  getCreatures() {
    return this.http.get("https://localhost:7076/creatures");
  }

  getBosses() {
    return this.http.get("https://localhost:7076/creatures/bosses");
  }
}