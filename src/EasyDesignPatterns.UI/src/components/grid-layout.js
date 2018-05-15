import React from 'react';
import './grid-layout.css';

const GridLayout = props => {
    return (
        <div className="grid-layout">
            {props.children}
        </div>
    )
}

export default GridLayout;