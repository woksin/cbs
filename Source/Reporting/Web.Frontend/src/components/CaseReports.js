import React, { Component } from "react";

export const BASE_URL = "http://localhost:3000/";

class CaseReports extends Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div className="case-reports--container">
                Here is where the case reports live!
            </div>
        );
    }
}

export default CaseReports;
