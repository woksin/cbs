import React, { Component } from "react";
import {QueryCoordinator} from '@dolittle/queries';
import {CommandCoordinator} from '@dolittle/commands';
import { AllDataCollectors } from "../app/Management/DataCollectors/AllDataCollectors";
import { DataCollector } from "../app/Management/DataCollectors/DataCollector";

import { commandCoordinator, queryCoordinator } from '../../coordinators';
import { AllCaseReportsForListing } from "../app/Reporting/CaseReportsForListing/AllCaseReportsForListing";
class Reporting extends Component {
    /**
     * @type {CommandCoordinator}
     *
     * @memberof Reporting
     */
    get commandCoordinator() {return commandCoordinator}
    /**
     *
     * @type {QueryCoordinator}
     * @memberof Reporting
     */
    get queryCoordinator() {return queryCoordinator};
    /**
     * @type {DataCollector[]}
     * @memberof Reporting
     */
    dataCollectors = [];
    caseReports = [];
    constructor(props) {
        super(props);
        
        this.queryCoordinator.execute(new AllDataCollectors()).then(_ => {
            this.dataCollectors = _.items; 
            console.log(this.dataCollectors);
        });
        this.queryCoordinator.execute(new AllCaseReportsForListing()).then(_ => {
            this.caseReports = _.items; 
            console.log(this.caseReports);
        });

    }
    render() {
        return (
            <div className="reporting--container">
                Welcome to Reporting!
            </div>
        );
    }
}

export default Reporting;
