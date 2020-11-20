import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../employee.model';
import { EmployeeService } from '../employee.service';
import { map } from 'rxjs/operators';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  id: number;
  displayedColumns: string[] = ['id', 'name', 'surname', 'age', 'salary', 'typecontract', 'actions'];
  employees: any[];

  constructor(
    private route: ActivatedRoute,
    private employeeService: EmployeeService
  ) { }

  ngOnInit() {
    this.employees = this.route.snapshot.data.employees;
  }

  getEmployee = (id) => {
    if(id){
      this.employeeService.getEmployee(id).subscribe((res) => { 
        this.employees = [];
        this.employees.push(res);
        console.log(this.employees);
      })
    }else{
      this.employeeService.getAll().subscribe((res) => { 
        this.employees = res;
        console.log(this.employees);
      })
    } 
  };

  navigateToEdit = (id) => console.log(`Modificando el empleado ${id}`);
  onDelete = (id) => console.log(`Eliminando el empleado ${id}`);
}
