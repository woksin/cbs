
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Route } from 'react-router-dom';

import '../assets/main.scss';
import Reporting from '../components/Reporting';
import mockCommandCoordinator from '../../mocking/MockCommandCoordinator';


ReactDOM.render(
    <BrowserRouter>
        <Route path="/" exact component={Reporting} />
    </BrowserRouter>,
    document.getElementById('app')
);
