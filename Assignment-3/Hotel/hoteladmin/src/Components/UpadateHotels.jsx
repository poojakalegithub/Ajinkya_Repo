import React, { useState } from "react";
import data from "./Data/HotelData.json"
const UpadateHotels = () => {
  const [name, setName] = useState("");
  const [type, settype] = useState("");
  const [price, setprice] = useState(0);
  const [size, setsize] = useState(0);
  const [capacity, setcapacity] = useState(1);
  const [description, setdescription] = useState("");
  const [id, setid] = useState("");
  const [UserData,setUserData] = useState(data);


  function getUsers() {
    fetch("http://localhost:8000/Hotels").then((result) => {
      result.json().then((resp) => {
        // console.warn(resp)
        setUserData(resp)
        setName(resp[0].name)
        settype(resp[0].type)
        setprice(resp[0].price)
        setsize(resp[0].size)
        setcapacity(resp[0].capacity)
        setdescription(resp[0].description)
        setid(resp[0].id)
      })
    })
  }

function UpdateData()
{
  let data={name,type,price,size,capacity,description}
  console.warn(data);
  fetch(`http://localhost:4000/Hotels/${UserData.Hotels.id}`, {
    method: "PUT",
    headers: {
      'Accept': 'application/json',
      'Content-Type': 'application/json',
    },
    body:JSON.stringify(data)
  }).then((resp)=>{
    console.warn("resp",resp);;
    resp.json().then((result)=>{
      console.warn("result",result)
      getUsers()
    })
  })
}
  return (
    <div className="container my-5">
      <div className="row">
        <div className="col-md-10 mx-auto col-12 card shadow-lg border-0 p-4">
          <div>
            <h1 className="display-4 text-center">Update Hotels</h1>
          </div>

          <div className="row my-4">
            <div className="col-md-12 col-12 my-auto">
              <div className="col-md-12 col-12 float-right">
                <form>
                  <div className="form-group">
                    <label htmlFor="name">Name</label>
                    <input
                      type="text"
                      className="form-control"
                      value={name}
                      onChange={(e) => setName(e.target.value)}
                      id="name"
                      placeholder="Hotel name"
                      required
                    />
                    <label htmlFor="type">Type</label>
                    <input
                      type="text"
                      className="form-control"
                      value={type}
                      onChange={(e) => settype(e.target.value)}
                      id="type"
                      placeholder="Hotel type"
                      required
                    />

                    <label htmlFor="price">Price</label>
                    <input
                      type="number"
                      value={price}
                      onChange={(e) => setprice(e.target.value)}
                      className="form-control"
                      required
                      id="price"
                      placeholder="Hotel price"
                    />
                    <label htmlFor="size">Size</label>
                    <input
                      type="number"
                      className="form-control"
                      value={size}
                      onChange={(e) => setsize(e.target.value)}
                      required
                      id="size"
                      placeholder="Hotel Size"
                    />
                    <label htmlFor="capacity">Capacity</label>
                    <input
                      type="number"
                      value={capacity}
                      onChange={(e) => setcapacity(e.target.value)}
                      className="form-control"
                      required
                      id="capacity"
                      placeholder="Capacity"
                    />
                    <label htmlFor="description">Description</label>
                    <textarea
                      className="form-control"
                      value={description}
                      onChange={(e) => setdescription(e.target.value)}
                      id="description"
                      placeholder="Short description of room."
                      rows="3"
                    ></textarea>
                  </div>

                  <div className="form-group form-check"></div>
                </form>
                <button onClick={()=>UpdateData(UserData.Hotels.id)}
                  className="btn btn-block btn-outline-primary"

                >
                   UPDATE
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default UpadateHotels;
