import React from 'react';
import './lateral-left.css';
import PropTypes from 'prop-types'

const LateralLeft = props => {

    return (
        <div className="lateral-left">
            <div>{props.actualRoute}</div>
            {props.showReturnArrow
                ? <i onClick={props.returnLocation} className="fas fa-arrow-left lateral-left-arrow"></i>
                : null
            }
        </div>
    )
}

LateralLeft.propTypes={
    actualRoute: PropTypes.string.isRequired,
    showReturnArrow: PropTypes.bool,
    returnLocation: PropTypes.func
}

export default LateralLeft;