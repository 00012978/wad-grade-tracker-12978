import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { provideNativeDateAdapter } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { Assignment12978Service } from '../../services/assignment12978.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Assignment12978 } from '../../interfaces/assignment12978';
import { Module12978Service } from '../../services/module12978.service';

@Component({
  selector: 'app-edit-assignment12978',
  standalone: true,
  imports: [FormsModule, MatFormFieldModule, MatSelectModule, MatInputModule, MatButtonModule, MatDatepickerModule],
  providers: [provideNativeDateAdapter()],
  templateUrl: './edit-assignment12978.component.html',
  styleUrl: './edit-assignment12978.component.css'
})
export class EditAssignment12978Component {
  assignmentService = inject(Assignment12978Service)
  activatedRoute = inject(ActivatedRoute);
  moduleService = inject(Module12978Service)

  router = inject(Router);
  module: any; 
  assignmentType: any;
  moduleID: number = 0;
  typeID: number = 0;

  editAssignment: Assignment12978 = {
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
    this.assignmentService.getAssignmentTypes().subscribe((result)=>{
      this.assignmentType = result
    });
    this.assignmentService.getByID(this.activatedRoute.snapshot.params["id"]).subscribe(result => {
      this.editAssignment = result;
      this.moduleID = this.editAssignment.moduleId;
      this.typeID = this.editAssignment.assignmentTypeId;
    });
    this.moduleService.getAll().subscribe((result) => {
      this.module = result;
    });
  };

  Edit() {
    this.editAssignment.moduleId = this.moduleID;
    this.assignmentService.edit(this.editAssignment.id, this.editAssignment).subscribe({
      next: (result) =>{
      alert("The assignment has been changed successfully!")
      this.router.navigateByUrl("home");
    },
    error: (error)=>{
      alert(`The following error occurred: ${error.message}`);
    }
  })
  };

  Cancel(){
    this.router.navigateByUrl("home");
  }
}
