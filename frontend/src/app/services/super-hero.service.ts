import { Injectable } from '@angular/core';
import { SuperHero } from '../models/super-hero';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SuperHeroService {
  private url = "SuperHero";
  constructor(private http: HttpClient) { }

  public getSuperHeros() : Observable<SuperHero[]>{
    return this.http.get<SuperHero[]>(`${environment.apiUrl}/${this.url}`);
  }
}
