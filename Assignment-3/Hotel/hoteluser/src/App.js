import "./App.css";
import NavBar from "./Components/NavBar";
import Login from "./Components/Login";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Registration from "./Components/Registration";
import HotelList from "./Components/HotelList";
import Footer from "./Components/Footer";
import BookTable from "./Components/BookTable";
import Reservation from "./Components/Reservation"
function App() {
  return (
    <>
      
      <BrowserRouter>
        <NavBar />
        <hr/>
        <hr/>
        <hr/>
        <Footer />
        <Routes>
          <Route path="/HotelList" element={<HotelList />} />
          <Route path="/Login" element={<Login />} />
          <Route path="/Registration" element={<Registration />} />
          <Route path="/Reservation" element={<Reservation />} />
          <Route path="/BookTable" element={<BookTable />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}
export default App;
