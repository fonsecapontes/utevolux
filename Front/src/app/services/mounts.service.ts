import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class MountsService {
  constructor(private http: HttpClient) { }

  get() {
    return this.http.get("https://localhost:7076/mounts");
  }
}