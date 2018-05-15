import React from 'react';
import './card-item.css';

const CardItem = props => {

  return (
    <div className="card-item">
      <div className="card-item-title">{props.children}</div>
      <div className="card-item-footer"></div>
    </div>
  )
}

export default CardItem;