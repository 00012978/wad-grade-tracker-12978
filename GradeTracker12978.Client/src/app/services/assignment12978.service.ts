import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Assignment12978 } from '../interfaces/assignment12978';

@Injectable({
  providedIn: 'root'
})
export class Assignment12978Service {
  httpClient = inject(HttpClient);
  constructor() { }

  getAll(){
    return this.httpClient.get<Assignment12978[]>("http://localhost:5010/api/Assignment12978")
  };

  getByID(id:number){
    return this.httpClient.get<Assignment12978>("http://localhost:5010/api/Assignment12978/"+id);
  };

  edit(id:number, item:Assignment12978){
    return this.httpClient.put("http://localhost:5010/api/Assignment12978/"+id, item);  
  };

  delete(id:number){
    return this.httpClient.delete("http://localhost:5010/api/Assignment12978/"+id);
  };

  create(item:Assignment12978){
    return this.httpClient.post<Assignment12978>("http://localhost:5010/api/Assignment12978", item);
  };

  getAssignmentTypes(){
    return this.httpClient.get<Assignment12978[]>("http://localhost:5010/api/AssignmentType12978")
  };
}
