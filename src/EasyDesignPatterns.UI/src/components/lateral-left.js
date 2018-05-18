import React from 'react';
import './lateral-left.css';
import PropTypes from 'prop-types'
import ReturnRow from './return-row';

const LateralLeft = props => {

    return (
        <div className="lateral-left">
            <div>{props.actualRoute}</div>
            <ReturnRow returnLocation={props.returnLocation} showReturnArrow={props.showReturnArrow} />
        </div>
    )
}

LateralLeft.propTypes={
    actualRoute: PropTypes.string.isRequired,
    showReturnArrow: PropTypes.bool,
    returnLocation: PropTypes.func
}

export default LateralLeft;