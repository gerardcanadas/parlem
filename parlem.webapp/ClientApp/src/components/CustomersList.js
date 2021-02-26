import React, { Component } from 'react';

export class CustomersList extends Component {
  static displayName = CustomersList.name;

  constructor(props) {
    super(props);
    this.state = { customersList: [], loading: true };
  }

  componentDidMount() {
    this.populateCustomerData();
  }

  static renderCustomerTable(customersList) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Núm. de document</th>
            <th>Tipus de document</th>
            <th>Email</th>
            <th>Nom i cognom</th>
          </tr>
        </thead>
        <tbody>
          {customersList.map(cust =>
            <tr key={cust.docNum}>
              <td>{cust.docNum}</td>
              <td>{cust.docType}</td>
              <td>{cust.email}</td>
              <td>{cust.givenName} {cust.familyName1}</td>
              <td>
                <Button title="Go to Details" 
                  onPress={() => {
                          /* 1. Navigate to the Details route with params */
                          navigation.navigate('Details', {
                            itemId: 86,
                            otherParam: 'anything you want here',
                        });
                    }}
                /></td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : CustomersList.renderCustomerTable(this.state.customersList);

    return (
      <div>
        <h1 id="tabelLabel" >Customer page</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateCustomerData() {
    const response = await fetch('https://localhost:5001/api/customer/list');
    const data = await response.json();
    this.setState({ customersList: data, loading: false });
  }

  async fetchCustomerProductsById(customerId) {
    const response = await fetch('https://localhost:5001/api/customer/' + customerId + '/products');
    const data = await response.json();
    this.setState({ selectedCustomerProducts: data, loading: false });
  }
}
