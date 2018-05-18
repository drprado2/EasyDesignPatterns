import React from 'react';
import PropTypes from 'prop-types';

const ReturnRow = props =>
    props.showReturnArrow
      ? <i onClick={props.returnLocation} style={props.style} className="fas fa-arrow-left lateral-left-arrow"></i>
      : null

ReturnRow.propTypes={
  showReturnArrow: PropTypes.bool.isRequired,
  returnLocation: PropTypes.func,
  style: PropTypes.shape
}

ReturnRow.defaultProps={
  style: {}
}

export default ReturnRow;
