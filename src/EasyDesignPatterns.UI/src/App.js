import React, { Component } from 'react';
import './App.css';
import { Provider } from 'react-redux';
import {store, history} from './store';
import {Route, Router, Switch, Redirect} from "react-router-dom";
import Pages from './pages';
import Layout from './components/layout';
import urls from './page-urls';
import {goHome} from './actions/location-actions';

class App extends Component {
  componentDidMount(){
      store.dispatch(goHome())
  }

  render() {
    return (
        <Provider store={store}>
            <Router history={history} >
                <Switch>
                    <Layout>
                        <Pages history={history} />
                    </Layout>
                </Switch>
            </Router>
        </Provider>
    );
  }
}

export default App;
