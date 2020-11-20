import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeeListComponent } from './employee-list/employee-list.component';
import { EmployeesResolver } from './employees.resolver';

const routes: Routes = [
  {
    path: '',
    component: EmployeeListComponent,
    resolve: {employees : EmployeesResolver}
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmployeeRoutingModule { }