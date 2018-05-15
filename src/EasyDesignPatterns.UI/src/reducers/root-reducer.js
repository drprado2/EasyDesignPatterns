import { combineReducers } from 'redux';
import { routerReducer } from 'react-router-redux'
import {locationReducer} from './location-reducer';

export default combineReducers({
    routing: routerReducer,
    locationReducer: locationReducer
});