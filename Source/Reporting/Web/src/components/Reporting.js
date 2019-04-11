import React, { Component } from "react";
import {QueryCoordinator} from '@dolittle/queries';
import {CommandCoordinator} from '@dolittle/commands';
import { AllDataCollectors } from "../app/Management/DataCollectors/AllDataCollectors";
import { DataCollector } from "../app/Management/DataCollectors/DataCollector";
class Reporting extends Component {
    /**
     * @type {CommandCoordinator}
     *
     * @memberof Reporting
     */
    commandCoordinator;
    /**
     *
     * @type {QueryCoordinator}
     * @memberof Reporting
     */
    queryCoordinator;
    /**
     * @type {DataCollector[]}
     * @memberof Reporting
     */
    dataCollectors = [];
    constructor(props) {
        super(props);
        this.commandCoordinator = props.commandCoordinator;
        this.queryCoordinator = props.queryCoordinator;

        this.queryCoordinator.execute(new AllDataCollectors()).then(_ => {
            this.dataCollectors = _.items; 
            console.log(this.dataCollectors);
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
