import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { Router } from '@angular/router';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {provideNativeDateAdapter} from '@angular/material/core';
import { Assignment12978Service } from '../../services/assignment12978.service';
import { Assignment12978 } from '../../interfaces/assignment12978';
import { Module12978Service } from '../../services/module12978.service';


@Component({
  selector: 'app-create-assignment12978',
  standalone: true,
  imports: [FormsModule, MatFormFieldModule, MatSelectModule, MatInputModule, MatButtonModule, MatDatepickerModule],
  providers: [provideNativeDateAdapter()],
  templateUrl: './create-assignment12978.component.html',
  styleUrl: './create-assignment12978.component.css'
})
export class CreateAssignment12978Component {
  assignmentService = inject(Assignment12978Service)
  moduleService = inject(Module12978Service)

  router = inject(Router);
  module: any; 
  assignmentType: any;
  moduleID: number = 0;
  typeID: number = 0;

  createAssignment: Assignment12978 = {
    id: 0,
    title: "",
    weighting: 0,
    dueDate: new Date(),
    grade: 0,
    assignmentTypeId: 0,
    assignmentTypeName: "",
    moduleId: 0,
    moduleTitle: ""
  }

  ngOnInit() {
    this.moduleService.getAll().subscribe((result) => {
      this.module = result
    }); // get all projects on init
    this.assignmentService.getAssignmentTypes().subscribe((result)=>{
      this.assignmentType = result
    });
  };

  Create() {
    this.createAssignment.moduleId = this.moduleID 
    this.createAssignment.assignmentTypeId = this.typeID
    this.assignmentService.create(this.createAssignment).subscribe(
      {
      next: () => {
        alert("Assignment was saved successfully")
        this.router.navigateByUrl("home");
      },
      error: (error) => {
        alert(`The following error ocurred upon request: ${error.message}`); // handle errors 
      }
    });
  };

  Cancel(){
    this.router.navigateByUrl("home");
  }
}
