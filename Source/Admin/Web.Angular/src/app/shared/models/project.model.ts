import { NationalSociety } from './index';
import { User } from './user.model';
import { ProjectSurveillanceContext } from './ProjectSurveillanceContext';
import { ProjectHealthRisk } from './ProjectHealthRisk.model';

export class Project {
    id: string;
    name: string;
    nationalSociety: NationalSociety;
    dataOwner: User;
    surveillanceContext: ProjectSurveillanceContext;

    healthRisks: ProjectHealthRisk[];
    dataVerifiers: User[];

    // dataVerifiers
}