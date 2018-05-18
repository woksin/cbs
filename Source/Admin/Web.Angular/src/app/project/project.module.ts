import { NgModule } from '@angular/core';

import { SharedModule } from '../shared/shared.module';
import { ProjectRouting } from './project-routing.module';
import { AddProjectComponent } from './add-project/add-project.component';
import { ProjectListComponent } from './project-list/project-list.component';
import { ProjectDetailComponent } from './project-detail/project-detail.component';

@NgModule({
    imports: [
        ProjectRouting,
        SharedModule
    ],
    declarations: [
        AddProjectComponent, 
        ProjectListComponent,
        ProjectDetailComponent
    ]
})

export class ProjectModule { }
