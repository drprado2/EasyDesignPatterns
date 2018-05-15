import {push, goBack, replace} from 'react-router-redux';
import {actionsTypes} from './action-types';
import urls from '../page-urls';

export const goLocation = url => {
    return dispatch => {
        dispatch(push(url.url));
        dispatch({type: actionsTypes.GO_LOCATION, newLocation: url.label});
    }
}

export const goHome = () => {
return dispatch => {
    dispatch(replace(urls.Home.url));
    dispatch({type: actionsTypes.GO_HOME, newLocation: urls.Home.label});
}
}

export const returnLocation = () => {
    return dispatch => {
        dispatch(goBack());
        dispatch({type: actionsTypes.RETURN_LOCATION});
    }
}
