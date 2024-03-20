import { Component, inject } from '@angular/core';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navigation12978',
  standalone: true,
  imports: [MatToolbarModule, MatButtonModule, MatIconModule],
  templateUrl: './navigation12978.component.html',
  styleUrl: './navigation12978.component.css'
})
export class Navigation12978Component {
  router = inject(Router);

  GoHome(){
    this.router.navigateByUrl("home")
  }
  
  ShowAssignments(){
    this.router.navigateByUrl("assignments")
  }

  AddAssignment(){
    this.router.navigateByUrl("createAssignment")
  }
}
