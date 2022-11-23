import React from "react";
import { useState } from "react";
import Data from "./Data/UserData.json";
import {Link} from "react-router-dom"

function HotelList() {
  const [UserData, setUserData] = useState(Data.Hotels);

  return UserData.map((data) => {
    return (
      <div class="container text-center">
        <div class="card mb-3">
          <div class="row g-0">
            <div class="col-md-4">
              <img src="https://www.bing.com/th?id=OIP.-96oy5GC5zmMo7izj1cAWQHaLH&w=204&h=306&c=8&rs=1&qlt=90&o=6&dpr=1.5&pid=3.1&rm=2" class="img-fluid rounded-start" alt="..." />
            </div>
            <div class="col-md-8">
              <div class="card-body">
                <h5 class="card-title">{data.name}</h5>
                <p class="card-text">
                  Type: {data.type}<br/>
                  Price: {data.price}<br/>
                  Area: {data.area}<br/>
                  Capacity: {data.capacity}<br/>
                  Description: {data.description}</p>
                <p class="card-text">
                  <small class="text-muted">{data.id} min ago.</small>
                </p>
                <button  className="btn btn-block btn-outline-primary">
                <Link class="nav-link" to="/BookTable"> Book </Link>
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
      
    );
    
  })
}

export default HotelList;
