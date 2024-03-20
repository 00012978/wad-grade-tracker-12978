import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Module12978 } from '../interfaces/module12978';

@Injectable({
  providedIn: 'root'
})
export class Module12978Service {
  httpClient = inject(HttpClient);
  constructor() { }

  getAll(){
    return this.httpClient.get<Module12978[]>("http://localhost:5010/api/LearningModule12978")
  };

  getByID(id:number){
    return this.httpClient.get<Module12978>("http://localhost:5010/api/LearningModule12978/"+id);
  }

  edit(id:number, item:Module12978){
    return this.httpClient.put("http://localhost:5010/api/LearningModule12978/"+id, item);  
  }

  delete(id:number){
    console.log("I'm deleting!")
    return this.httpClient.delete("http://localhost:5010/api/LearningModule12978/"+id);
  }

  create(item:Module12978){
    return this.httpClient.post<Module12978>("http://localhost:5010/api/LearningModule12978", item);
  }
}
