import { Component, inject } from '@angular/core';
import { Module12978Service } from '../../services/module12978.service';
import { Router } from '@angular/router';
import { Module12978 } from '../../interfaces/module12978';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

@Component({
  selector: 'app-create-module12978',
  standalone: true,
  imports: [FormsModule, MatFormFieldModule, MatInputModule, MatButtonModule],
  templateUrl: './create-module12978.component.html',
  styleUrl: './create-module12978.component.css'
})
export class CreateModule12978Component {
  moduleService = inject(Module12978Service)

  router = inject(Router);
  createModule: Module12978 = {
    id: 0,
    title: "",
    code: "",
    credits: 0,
    totalMark: 0,
    assignments: []
  }

  Create() {
    this.moduleService.create(this.createModule).subscribe(
      {
      next: () => {
        alert("Module was saved successfully")
        this.router.navigateByUrl("home");
      },
      error: (error) => {
        alert(`The following error ocurred upon request: ${error.message}`);
      }
    });
  };

  Cancel(){
    this.router.navigateByUrl("home");
  }
}
