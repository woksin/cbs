import { OnInit, Input, Component } from "@angular/core";
import { Project } from "../../shared/models";
import { ActivatedRoute } from "@angular/router";
import { ProjectService } from "../../core/project.service";
import { Location } from "@angular/common";

@Component({
    selector: 'cbs-project-detail',
    templateUrl: './project-detail.component.html'
})

export class ProjectDetailComponent implements OnInit{
    ngOnInit(): void {
        this.getProject();
    }
    @Input() project : Project;

    constructor(
        private route: ActivatedRoute,
        private projectService: ProjectService,
        private location: Location
    ) {}

    getProject(): void {
        const id = this.route.snapshot.paramMap.get('id');
         this.projectService.getProject(id)
            .subscribe((project) => {
                console.log(project);
                this.project = project;
            }, error => console.error(error)
        );

    }

    goBack(): void  {
        this.location.back();
    }
}