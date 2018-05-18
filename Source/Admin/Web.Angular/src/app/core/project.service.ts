import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import { ApiService } from './api.service';
import { AddProject } from '../shared/models/add-project.model';
import { Project } from '../shared/models/project.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';

const httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
@Injectable()
export class ProjectService {
      
    constructor(private apiService: ApiService, private http: HttpClient) { }

    saveProject(item: AddProject) {
        let project = new AddProject();
        project = item; 
        
        this.apiService.post('/api/project', project);
    }

    getProjects(): Observable<Array<Project>> {
        return this.apiService
            .get('/api/project');
    }

    getProject(id: string): Observable<Project> {
        const url = `${environment.api}/api/project/${id}`;

        return this.http.get<Project>(url, httpOptions);

    }
}