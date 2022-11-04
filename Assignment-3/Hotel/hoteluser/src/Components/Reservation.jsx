import React, { useEffect, useState } from "react";
import data from "./Data/UserData.json";

function Reservation() {
  const [UserData, setUserData] = useState(data.Table);

  return (
    <div>
      <h1>Your Reservation</h1>
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Number</th>
            <th>Email</th>
            <th>Table</th>
            <th>Time</th>
          </tr>
        </thead>
        <tbody>
          {UserData.map((userdata) => (
            <tr>
              <td>{userdata.name}</td>
              <td>{userdata.number}</td>
              <td>{userdata.email}</td>
              <td>{userdata.table}</td>
              <td>{userdata.time}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Reservation;
