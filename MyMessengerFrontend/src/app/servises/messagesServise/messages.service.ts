import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {BackendUrl} from '../../constants/constants';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class MessagesService {

  constructor(private http: HttpClient) { }

  getMessages(): Observable<string[]> {
    const url = BackendUrl + '/Values';
    return this.http.get<string[]>(url);
  }
}
