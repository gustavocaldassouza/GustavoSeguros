import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { SeguroCollection } from './models/segurocolletion';
@Injectable({
  providedIn: 'root',
})
export class SeguroService {
  private baseurl = 'http://localhost:88';
  constructor(private http: HttpClient) {}
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      accept: '*/*',
    }),
  };

  GetSeguros(): Observable<SeguroCollection> {
    return this.http
      .get<SeguroCollection>(this.baseurl + '/gerarrelatorio')
      .pipe(retry(1), catchError(this.errorHandl));
  }

  errorHandl(error: any) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(() => {
      return errorMessage;
    });
  }
}
