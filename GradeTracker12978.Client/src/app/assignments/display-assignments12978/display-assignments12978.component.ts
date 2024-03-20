import { Component, inject } from '@angular/core';
import { Assignment12978Service } from '../../services/assignment12978.service';
import { Router } from '@angular/router';
import { Assignment12978 } from '../../interfaces/assignment12978';
import { MatTableModule } from '@angular/material/table';
import { MatButton } from '@angular/material/button';

@Component({
  selector: 'app-display-assignments12978',
  standalone: true,
  imports: [MatTableModule, MatButton],
  templateUrl: './display-assignments12978.component.html',
  styleUrl: './display-assignments12978.component.css'
})
export class DisplayAssignments12978Component {
  displayedColumns: string[] = ['ID', 'Title', 'Weighting', 'Due Date', 'Grade', 'Assignment Type', 'Module Title', 'Actions'];
  assignmentService = inject(Assignment12978Service);
  router = inject(Router)
  items:Assignment12978[]=[];

  ngOnInit(){
    this.assignmentService.getAll()
        .subscribe((result)=>{this.items = result});
  }

  Edit(itemID:number){
    this.router.navigateByUrl(`editAssignment/${itemID}`)
  }

  Delete(itemID:number){
    this.assignmentService.delete(itemID).subscribe({
      next: () => {
        alert("The assignment was deleted. Its id was: " + itemID);
        window.location.reload();
      },
      error: (error) => {
        alert(`There was the following error: ${error.message}`); 
      }
    });
  }
}
