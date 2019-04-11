
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Route } from 'react-router-dom';
// Reacdom quckstart https://reacttraining.com/react-router/web/guides/quick-start
import '../assets/main.scss';
import Reporting from '../components/Reporting';
import { commandCoordinator, queryCoordinator } from '../../coordinators';


ReactDOM.render(
    <BrowserRouter>
        <Route path="/" 
        exact 
        render={props => (
            <Reporting {...props, commandCoordinator, queryCoordinator} />
        )}/>
    </BrowserRouter>,
    document.getElementById('app')
);
