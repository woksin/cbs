import React, { Component } from "react";

export const BASE_URL = "http://localhost:3000/";

class DataCollectors extends Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div className="data-collectors--container">
                Here is where the data collectors live!
            </div>
        );
    }
}

export default DataCollectors;
