import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'category',
    loadChildren: './category/category.module#CategoryModule'
  },
  {
    path: 'employee',
    loadChildren: './employee/employee.module#EmployeeModule'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
