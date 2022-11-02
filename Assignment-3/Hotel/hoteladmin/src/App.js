import "./App.css";
import Navbar from "./Components/Navbar";
import Sidebar from "./Components/Sidebar";
import Login from "./Components/Login";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Registration from "./Components/Registration";
import AddHotel from "./Components/AddHotel";
import ListHotels from "./Components/ListHotels";
import Bookings from "./Components/Bookings";
import UserList from "./Components/UserList"
import UpadateHotels from "./Components/UpadateHotels"

function App() {
  return (
    <>
      <Navbar/>
      <hr/>
      <hr/>
      <ListHotels/>
      <Bookings />
      <UserList/>
       <AddHotel/>
      <UpadateHotels/>

    </>
  );
}

export default App;
