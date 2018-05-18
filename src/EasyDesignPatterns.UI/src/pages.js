import React from 'react';
import {Route, Redirect, Switch} from "react-router-dom";
import {urls} from './page-urls';
import DesignPatternsListPage from './pages/design-patterns-list/design-patterns-list.page';
import ResourceNotFound from './components/resource-not-found';
import AbstractFactoryPage from './pages/abstract-factory/abstract-factory.page';
import CreationalPatternsPage from './pages/criational-patterns/creational-patterns.page';



const Pages = props => {

    return (
        <Switch>
            <Route exact path={urls.Home.url} component={DesignPatternsListPage} />
            <Route exact path={urls.AbstractFactory.url} component={AbstractFactoryPage} />
            <Route exact path={urls.CreationalPatterns.url} component={CreationalPatternsPage} />
            <Route component={ResourceNotFound} />
        </Switch>
    )
}

export default Pages;