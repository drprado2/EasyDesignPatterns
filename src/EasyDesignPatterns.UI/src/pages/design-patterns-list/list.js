import React from 'react';
import './list.css';
import PropTypes from 'prop-types';
import ListItem from './list-item';

const List = props => {

    return (
        <div className="list">
            {props.items.map((item, index) => <ListItem onClick={item.onClick} key={index}>{item.label}</ListItem>)}
        </div>
    )
}

List.propTypes={
    items: PropTypes.arrayOf(PropTypes.shape).isRequired
}

export default List;