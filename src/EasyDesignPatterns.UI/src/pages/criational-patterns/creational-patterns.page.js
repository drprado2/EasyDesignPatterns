import React, {Component} from 'react';
import CardList from './cards-list';
import CardItem from './card-item';

class CreationalPatternsPage extends Component{
  constructor(props){
    super(props);
  }

  render(){

    return(
      <CardList>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
        <CardItem>Abstract Factory</CardItem>
      </CardList>
    )
  }
}

export default CreationalPatternsPage;