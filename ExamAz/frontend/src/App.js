import "bootstrap/dist/css/bootstrap.min.css";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Home from "./Home/Home";
import Order from "./Order/Order";
import EditOrder from "./Order/EditOrder";
function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/add/order" element={<Order />} />
        <Route path="/edit/order/:id" element={<EditOrder />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
