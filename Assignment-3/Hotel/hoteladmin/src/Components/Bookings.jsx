import React, { useEffect, useState } from "react";
import data from "./Data/HotelData.json";
import Data from "./Data/HotelData.json";

function Bookings() {
  const [UserData, setUserData] = useState(data.Bookings);
  const [Userdata, setUserdata] = useState(Data.CancelsBookings);

  return (
    <div>
      <h1> Bookings </h1>
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Number</th>
            <th>Room</th>
            <th>Price</th>
            <th>Duration</th>
          </tr>
        </thead>
        <tbody>
          {UserData.map((userdata) => (
            <tr>
              <td>{userdata.name}</td>
              <td>{userdata.number}</td>
              <td>{userdata.room}</td>
              <td>{userdata.price}</td>
              <td>{userdata.duration}</td>
            </tr>
          ))}
        </tbody>
      </table>

      <h1> Cancel Bookings </h1>
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Number</th>
            <th>Room</th>
            <th>Price</th>
            <th>Duration</th>
          </tr>
        </thead>
        <tbody>
          {Userdata.map((userdata) => (
            <tr>
              <td>{userdata.name}</td>
              <td>{userdata.number}</td>
              <td>{userdata.room}</td>
              <td>{userdata.price}</td>
              <td>{userdata.duration}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Bookings;
