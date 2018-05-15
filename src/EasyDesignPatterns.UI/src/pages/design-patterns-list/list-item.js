import React from 'react';
import './list-item.css';
import PropTypes from 'prop-types';

const ListItem = props => {
    return (
        <div onClick={props.onClick} className="list-item">
            {props.children}
        </div>
    )
}

ListItem.propTypes={
    title: PropTypes.string,
    onClick: PropTypes.func.isRequired
}

export default ListItem;