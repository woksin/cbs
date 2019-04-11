import React, { Component } from "react";
import { Link } from "react-router-dom";

export const BASE_URL = "http://localhost:3000/";

class DataCollectors extends Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div className="data-collectors--container">
                <h1>Here is where the data collectors live!</h1>
                <Link to="/register-datacollector">Add data collectors</Link>
            </div>
        );
    }
}

export default DataCollectors;
