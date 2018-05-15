import React from 'react';
import './center-layout.css';

const CenterLayout = props => {

    return (
        <div className="center-layout">
            {props.children}
        </div>
    )
}

export default CenterLayout;

