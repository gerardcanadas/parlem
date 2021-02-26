import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { CustomersList } from './components/CustomersList';
import { CustomerProductsList } from './components/CustomerProductsList';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={CustomersList} />
      </Layout>
    );
  }
}
