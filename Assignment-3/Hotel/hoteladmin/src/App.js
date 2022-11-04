import "./App.css";
import Navbar from "./Components/Navbar";
import Sidebar from "./Components/Sidebar";
import Login from "./Components/Login";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Registration from "./Components/Registration";
import AddHotel from "./Components/AddHotel";
import ListHotels from "./Components/ListHotels";
import Bookings from "./Components/Bookings";
import UserList from "./Components/UserList";
import UpadateHotels from "./Components/UpadateHotels";
import SelectHotel from "./Components/SelectHotel";

function App() {
  return (
    <>
      <BrowserRouter>
        <Navbar />
        <hr />
        <hr />
        <Routes>
          <Route path="/ListHotels" element={<ListHotels />} />
          <Route path="/Login" element={<Login />} />
          <Route path="/AddHotel" element={<AddHotel />} />
          <Route path="/UpadateHotels" element={<UpadateHotels />} />
          <Route path="/Bookings" element={<Bookings />} />
          <Route path="/UserList" element={<UserList />} />
          <Route path="/SelectHotel" element={<SelectHotel />} />
          <Route path="/Registration" element={<Registration />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}
export default App;
