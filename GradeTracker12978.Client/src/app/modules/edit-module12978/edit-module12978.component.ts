import { Component, inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Module12978 } from '../../interfaces/module12978';
import { Module12978Service } from '../../services/module12978.service';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

@Component({
  selector: 'app-edit-module12978',
  standalone: true,
  imports: [FormsModule, MatFormFieldModule, MatInputModule, MatButtonModule],
  templateUrl: './edit-module12978.component.html',
  styleUrl: './edit-module12978.component.css'
})
export class EditModule12978Component {
  moduleService = inject(Module12978Service)

  activatedRoute = inject(ActivatedRoute)
  
  router = inject(Router)
  
  editModule: Module12978 = {
    id: 0,
    title: "",
    code: "",
    credits: 0,
    assignments: []
  }

  ngOnInit(){
    const moduleId = parseInt(this.activatedRoute.snapshot.params["id"], 10);
    this.moduleService.getByID(moduleId)
      .subscribe((resultedItem) => {
        this.editModule = resultedItem
      });
  }

  Edit() {
    this.moduleService.edit(this.editModule.id, this.editModule).subscribe({
      next: (result)=>{
        alert("The Module was updated successfully!")
        this.router.navigateByUrl("home");
      },
      error: (error) => {
        alert(`The following error occurred: ${error.message}`);
    }
  })
  }

  Cancel(){
    this.router.navigateByUrl("home");
  }
}
