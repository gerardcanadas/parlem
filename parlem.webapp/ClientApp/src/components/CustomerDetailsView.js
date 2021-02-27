import React, { Component } from 'react';

export class CustomerDetailsView extends Component {
  static displayName = CustomerDetailsView.name;

  constructor(props) {
    super(props);
    this.state = { customerData: [], loading: true };
  }

  componentDidMount() {
    this.populateCustomerData(1);
  }

  static renderCustomerDetails(customerData) {
    return (
      <ul>
        <li>Customer name: {customerData.givenName} {customerData.familyName1}</li>
        <li>Phone Number: {customerData.phoneNumber}</li>
        <li>Email: {customerData.email}</li>
        <li>{customerData.docType} : {customerData.docNum}</li>
      </ul>
    );
  }

  static renderCustomerProducts(customerProductsData) {
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
          {customerProductsData.map(prod =>
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
    let customerDetails = this.state.loading
      ? <p><em>Loading...</em></p>
      : CustomerDetailsView.renderCustomerDetails(this.state.customerData);

    let customerProducts = this.state.loading
      ? <p><em>Loading...</em></p>
      : CustomerDetailsView.renderCustomerProducts(this.state.customerData.customerProducts);

    return (
      <div>
        <h1 id="tabelLabel" >Customer view</h1>
        {customerDetails}

        {customerProducts}
      </div>
    );
  }

  async populateCustomerData(customerId) {
    const response = await fetch('https://localhost:5001/api/customer/' + customerId);
    const data = await response.json();
    console.log(data);
    this.setState({ customerData: data, loading: false });
  }
}
