
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Route } from 'react-router-dom';
// Reacdom quckstart https://reacttraining.com/react-router/web/guides/quick-start
import Reporting from '../components/Reporting';

import "../assets/react-leaflet.scss";
import "../assets/main.scss";


ReactDOM.render(
    <BrowserRouter>
        <Route path="/" 
        exact 
        render={props => (
            <Reporting />
        )}/>
    </BrowserRouter>,
    document.getElementById('app')
);
