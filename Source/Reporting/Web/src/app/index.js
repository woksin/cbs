
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Route } from 'react-router-dom';
// Reacdom quckstart https://reacttraining.com/react-router/web/guides/quick-start
import '../assets/main.scss';
import Reporting from '../components/Reporting';


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
