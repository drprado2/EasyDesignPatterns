import React from 'react';
import './resource-not-found.css';
import {goHome} from '../actions/location-actions';
import {connect} from "react-redux";
import {bindActionCreators} from 'redux';
import {withRouter} from 'react-router-dom';

const ResourceNotFound = props =>
    <div className="resource-not-found">
        <div className="resource-not-found-title">Página não encontrada</div>
        <div onClick={props.goHome} className="resource-not-found-message">Que tal voltar para página principal?</div>
    </div>

const mapDispatchToProps = dispatch => bindActionCreators({goHome}, dispatch);

export default withRouter(connect(null, mapDispatchToProps)(ResourceNotFound));
