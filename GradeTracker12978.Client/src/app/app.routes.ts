import { Routes } from '@angular/router';
import { DisplayModules12978Component } from './modules/display-modules12978/display-modules12978.component';
import { DisplayAssignments12978Component } from './assignments/display-assignments12978/display-assignments12978.component';
import { CreateAssignment12978Component } from './assignments/create-assignment12978/create-assignment12978.component';
import { CreateModule12978Component } from './modules/create-module12978/create-module12978.component';
import { EditModule12978Component } from './modules/edit-module12978/edit-module12978.component';
import { EditAssignment12978Component } from './assignments/edit-assignment12978/edit-assignment12978.component';

export const routes: Routes = [
    {
        path:"",
        component:DisplayModules12978Component
    },
    {
        path:"home",
        component:DisplayModules12978Component
    },
    {
        path:"assignments",
        component: DisplayAssignments12978Component
    },
    {
        path:"createAssignment",
        component: CreateAssignment12978Component
    },
    {
        path:"createModule",
        component: CreateModule12978Component
    },
    {
        path:"editModule/:id",
        component: EditModule12978Component
    },
    {
        path:"editAssignment/:id",
        component: EditAssignment12978Component
    }
];
