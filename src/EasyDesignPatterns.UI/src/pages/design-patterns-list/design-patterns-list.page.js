import React, {Component} from 'react';
import List from './list';
import {goLocation} from '../../actions/location-actions'
import urls from '../../page-urls';
import {connect} from "react-redux";
import {bindActionCreators} from 'redux';
import {withRouter} from 'react-router-dom';

class DesignPatternsListPage extends Component{
    constructor(props){
        super(props);
    }

    render() {
        const items = [
            { label: "Padrões Criacionais", onClick: () => this.props.goLocation(urls.AbstractFactory) },
            { label: "Padrões Estruturais", onClick: () => this.props.goLocation(urls.AbstractFactory) },
            { label: "Padrões Comportamentais", onClick: () => this.props.goLocation(urls.AbstractFactory) },
        ]

        return (
            <List items={items} />
        )
    }
}

const mapDispatchToProps = dispatch =>
    bindActionCreators({goLocation}, dispatch);

export default withRouter(connect(null, mapDispatchToProps)(DesignPatternsListPage));
