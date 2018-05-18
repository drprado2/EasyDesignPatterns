import React from 'react';
import './header.css';
import ReturnRow from './return-row';
import PropTypes from 'prop-types';

const Header = props => {
    return (
        <div className="header">
            <div className="header-return-button">
              <ReturnRow
                showReturnArrow={props.showReturnArrow}
                returnLocation={props.returnLocation}
                style={{fontSize: '1em'}}
              />
            </div>
            <div>
              Easy Design Patterns
            </div>
        </div>
    )
}

Header.propTypes={
  showReturnArrow: PropTypes.bool,
  returnLocation: PropTypes.func
}

export default Header;