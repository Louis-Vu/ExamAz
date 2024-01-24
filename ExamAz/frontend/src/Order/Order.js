import axios from "axios";
import React, { useState } from "react";

const Order = () => {
  const [inputData, setInputData] = useState({
    itemName: "",
    itemQty: "",
    orderDelivery: "",
    orderAddress: "",
    phoneNumber: "",
  });
  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(inputData);
    axios
      .post(`https://localhost:7102/api/Order`, inputData, {
        headers: {
          "Content-Type": "application/json",
        },
      })
      .then((res) => {
        alert("data added");
      })
      .catch((err) => console.log(err));
  };
  return (
    <form onSubmit={handleSubmit}>
      <div className="col-sm-6 mb-3 mb-sm-0">
        <label htmlFor="Name">Name</label>
        <input
          type="text"
          className="form-control"
          id="exampleFirstName"
          placeholder="Name"
          name="Name"
          required
          onChange={(e) =>
            setInputData({ ...inputData, itemName: e.target.value })
          }
        />
      </div>
      <div className="col-sm-6 mb-3 mb-sm-0">
        <label htmlFor="Name">Qty</label>
        <input
          type="number"
          className="form-control"
          id="exampleFirstName"
          required
          onChange={(e) =>
            setInputData({ ...inputData, itemQty: e.target.value })
          }
        />
      </div>
      <div className="col-sm-6 mb-3 mb-sm-0">
        <label htmlFor="Name">Order Delivery</label>
        <input
          type="date"
          className="form-control"
          id="exampleFirstName"
          required
          onChange={(e) =>
            setInputData({ ...inputData, orderDelivery: e.target.value })
          }
        />
      </div>
      <div className="col-sm-6 mb-3 mb-sm-0">
        <label htmlFor="Name">Order Address</label>
        <input
          type="text"
          className="form-control"
          id="exampleFirstName"
          required
          onChange={(e) =>
            setInputData({ ...inputData, orderAddress: e.target.value })
          }
        />
      </div>
      <div className="col-sm-6 mb-3 mb-sm-0">
        <label htmlFor="Name">Phone</label>
        <input
          type="text"
          className="form-control"
          id="exampleFirstName"
          required
          onChange={(e) =>
            setInputData({ ...inputData, phoneNumber: e.target.value })
          }
        />
      </div>
      <button className="btn btn-primary btn-user btn-block">Add Order</button>
    </form>
  );
};

export default Order;
