import React, { Component } from 'react';

export class CustomerProductsList extends Component {
  static displayName = CustomerProductsList.name;

  constructor(props) {
    super(props);
    this.state = { customerProductsList: [], loading: true };
  }

  componentDidMount() {
    this.populateCustomerProductsData();
  }

  static renderCustomerProductsTable(customerProductsList) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Producte</th>
            <th>Tipus</th>
            <th>Numeració del terminal</th>
            <th>Data de venta</th>
          </tr>
        </thead>
        <tbody>
          {customerProductsList.map(prod =>
            <tr key={prod.productName}>
              <td>{prod.productName}</td>
              <td>{prod.productTypeName}</td>
              <td>{prod.terminalNumeration}</td>
              <td>{prod.soldAt}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : CustomerProductsList.renderCustomerProductsTable(this.state.customersList);

    return (
      <div>
        <h1 id="tabelLabel" >Customer page</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateCustomerProductData(customerId) {
    const response = await fetch('https://localhost:5001/api/customer' + customerId + '/products');
    const data = await response.json();
    this.setState({ customerProductsList: data, loading: false });
  }
}
