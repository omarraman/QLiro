import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {Observable} from 'rxjs';
import {environment} from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RunSimulationService {

  env = environment;
  constructor(protected _httpClient: HttpClient) {

  }



  execute(numberOfSimulations: number,  doorSwitched: boolean): Observable<number> {
    const httpHeaders = new HttpHeaders()
      .set('Accept', 'application/json');
    const httpParams = new HttpParams();
    return this._httpClient.get<number> (this.env.baseUrl + '/api/Simulator/' + numberOfSimulations + '/' + doorSwitched,
      {
        headers: httpHeaders,
        params: httpParams,
        responseType: 'json'
      }
    )	}


  handleError(error: any)	{
    const _errMsg = (error.message)
      ? error.message
      : error.status
        ? `${ error.status}
		${ error.statusText}`
        : 'Server error';
    console.error(_errMsg);
    return Observable.throw (_errMsg);
  }
}
