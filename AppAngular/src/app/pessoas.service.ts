import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({
    'content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class PessoasService {
  url = 'https://localhost:5019/api/pessoas';

  constructor(private http: HttpClient) { }

  PegarTodos(): Observable<Pessoa> {

  }



}
