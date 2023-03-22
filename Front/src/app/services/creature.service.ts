import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class CreatureService {
  constructor(private http: HttpClient) { }

  get() {
    return this.http.get("https://localhost:7076/Creatures");
  }
}