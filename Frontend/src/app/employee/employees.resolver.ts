import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { EmployeeService } from './employee.service';

@Injectable({providedIn: 'root'})
export class EmployeesResolver implements Resolve<Observable<any>> {
    constructor(
        private employeeService: EmployeeService
    ) { }

    resolve(route: ActivatedRouteSnapshot) {
        return this.employeeService.getAll();
    }
}