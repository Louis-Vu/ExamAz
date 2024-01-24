import axios from "axios";
import React, { useState } from "react";
import { useParams } from "react-router-dom";
const EditOrder = () => {
  const { id } = useParams();
  const [inputData, setInputData] = useState({
    orderDelivery: "",
    orderAddress: "",
  });
  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(inputData);
    axios
      .put(`https://localhost:7102/api/Order/${id}`, inputData, {
        headers: {
          "Content-Type": "application/json",
        },
      })
      .then((res) => {
        alert("edit success");
      })
      .catch((err) => console.log(err));
  };
  return (
    <form onSubmit={handleSubmit}>
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
      <button className="btn btn-primary btn-user btn-block">Edit Order</button>
    </form>
  );
};

export default EditOrder;
