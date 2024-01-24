import React, { useEffect, useState } from "react";
import Table from "react-bootstrap/Table";
import axios from "axios";
import { Link } from "react-router-dom";

const Home = () => {
  const [orders, setOrders] = useState();
  useEffect(() => {
    axios
      .get(`https://localhost:7102/api/Order`, {
        headers: {
          "Content-Type": "application/json",
        },
      })
      .then((res) => setOrders(res.data))
      .catch((err) => console.error(err));
  }, []);
  return (
    <div>
      <Link to={"/add/order"}>Add Order</Link>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>Item Code</th>
            <th>Item Name</th>
            <th>Item Qty</th>
            <th>Order Delivery</th>
            <th>Order Address</th>
            <th>Phone Number</th>
            <th>Edit</th>
          </tr>
        </thead>
        <tbody>
          {orders?.map((o, i) => (
            <tr key={i}>
              <td>{o.id}</td>
              <td>{o.itemName}</td>
              <td>{o.itemQty}</td>
              <td>{o.orderDelivery}</td>
              <td>{o.orderAddress}</td>
              <td>{o.phoneNumber}</td>
              <td>
                <Link to={`/edit/order/${o.id}`}>Edit</Link>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
};

export default Home;
