import { Component, inject } from '@angular/core';
import {MatTableModule} from '@angular/material/table';
import { Router } from '@angular/router';
import { Module12978Service } from '../../services/module12978.service';
import { MatButtonModule } from '@angular/material/button';
import { Module12978 } from '../../interfaces/module12978';
import { MatCardModule } from '@angular/material/card';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-display-modules12978',
  standalone: true,
  imports: [MatTableModule, MatButtonModule, MatCardModule, CommonModule],
  templateUrl: './display-modules12978.component.html',
  styleUrl: './display-modules12978.component.css'
})
export class DisplayModules12978Component {
  moduleService = inject(Module12978Service);
  router = inject(Router)
  items:Module12978[]=[]; // empty list of modules

  ngOnInit(){
    this.moduleService.getAll()
        .subscribe((result)=>{this.items = result}); // get all modules from the api
  }

  Edit(itemID:number){
    this.router.navigateByUrl(`editModule/${itemID}`)
  }

  Delete(itemID:number){
    this.moduleService.delete(itemID).subscribe({
      next: () => {
        alert("The module was deleted. Its id was: " + itemID);
        window.location.reload();
      },
      error: (error) => {
        alert(`There was the following error: ${error.message}`); 
      }
    });
  }

  AddModule(){
    this.router.navigateByUrl("createModule")
  }
}
