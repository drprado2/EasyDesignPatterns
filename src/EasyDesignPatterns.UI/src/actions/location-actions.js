import {push, goBack, replace} from 'react-router-redux';
import {urls} from '../page-urls';

export const goLocation = url => {
    return dispatch => {
        dispatch(push(url.url));
    }
}

export const goHome = () => {
return dispatch => {
    dispatch(replace(urls.Home.url));
  }
}

export const returnLocation = () => {
    return dispatch => {
        dispatch(goBack());
    }
}
