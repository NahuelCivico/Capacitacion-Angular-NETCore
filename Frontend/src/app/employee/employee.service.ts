import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Employee } from './employee.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private employeeUrl = environment.baseUrl + 'employee';

  constructor(
    private httpClient: HttpClient
  ) { }

  public getAll(): Observable<Employee[]> {
    return this.httpClient.get<Employee[]>(this.employeeUrl);
  }

  public getEmployee(id: number): Observable<Employee[]> {
    return this.httpClient.get<Employee[]>(this.employeeUrl  + '/' + id);
  }
}
