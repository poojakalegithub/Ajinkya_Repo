import React, { useEffect, useState } from "react";
import data from "./Data/HotelData.json";

function Table() {
  const [UserData, setUserData] = useState(data.UserData);

  return (
    <div>
      <h1> Users </h1>
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Email</th>
            <th>Number</th>
          </tr>
        </thead>
        <tbody>
          {UserData.map((userdata) => (
            <tr>
              <td>{userdata.name}</td>
              <td>{userdata.email}</td>
              <td>{userdata.number}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Table;
