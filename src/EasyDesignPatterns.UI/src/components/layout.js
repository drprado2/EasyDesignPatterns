import React from 'react';
import CenterLayout from './center-layout';
import LateralLeft from './lateral-left';
import LateralRight from './lateral-right';
import GridLayout from './grid-layout';
import Header from './header';
import {connect} from "react-redux";
import {bindActionCreators} from 'redux';
import {withRouter} from 'react-router-dom';
import {goLocation, returnLocation} from '../actions/location-actions';

const Layout = props => {

    return (
        <GridLayout>
            <Header/>
            <LateralLeft returnLocation={props.returnLocation} showReturnArrow={props.showReturnArrow} actualRoute={props.actualRoute} />
            <CenterLayout>{props.children}</CenterLayout>
            <LateralRight/>
        </GridLayout>
    )
}

const mapStateToProps = (state) => {
    return {
        actualRoute: state.locationReducer.actualRoute,
        showReturnArrow: state.locationReducer.showReturnArrow,
    }
}

const mapDispatchToProps = dispatch =>
    bindActionCreators({goLocation, returnLocation}, dispatch);


export default withRouter(connect(mapStateToProps, mapDispatchToProps)(Layout));
