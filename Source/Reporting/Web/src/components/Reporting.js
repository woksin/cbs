import React, { Component } from "react";

class Reporting extends Component {
    commandCoordinator;
    queryCoordinator;
    constructor(props) {
        super(props);
        this.commandCoordinator = props.commandCoordinator;
        this.queryCoordinator = props.queryCoordinator;
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
