import React, { useEffect, useState } from "react";

const BookTable = () => {
  const [name, setname] = useState("");
  const [number, setnumber] = useState("");
  const [email, setemail] = useState("");
  const [table, settable] = useState("");
  const [time, settime] = useState("");
  

  function saveData() {
    let data = { name,number,email,table,time };
    console.warn(data);
    fetch("http://localhost:3002/Table", {
      method: "POST",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
      },
      body: JSON.stringify(data),
    }).then((resp) => {
      console.warn("resp", resp);
      resp.json().then((result) => {
        console.warn("result", result);
      });
    });
  }

  return (
    <div className="container my-5">
      <div className="row">
        <div className="col-md-10 mx-auto col-12 card shadow-lg border-0 p-4">
          <div>
            <h1 className="display-4 text-center">Book Table</h1>
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
                      onChange={(e) => setname(e.target.value)}
                      id="name"
                      placeholder="Your name"
                      required
                    />
                    <label htmlFor="type">Number</label>
                    <input
                      type="text"
                      className="form-control"
                      value={number}
                      onChange={(e) => setnumber(e.target.value)}
                      id="type"
                      placeholder="Your number"
                      required
                    />

                    <label htmlFor="price">Email</label>
                    <input
                      type="text"
                      value={email}
                      onChange={(e) => setemail(e.target.value)}
                      className="form-control"
                      required
                      id="price"
                      placeholder="Your Email"
                    />
                    <label htmlFor="size">Table for how many ?</label>
                    <input
                      type="text"
                      className="form-control"
                      value={table}
                      onChange={(e) => settable(e.target.value)}
                      required
                      id="size"
                      placeholder="we need a number"
                    />
                    <label htmlFor="Table">Time</label>
                    <input
                      type="text"
                      value={time}
                      onChange={(e) => settime(e.target.value)}
                      className="form-control"
                      required
                      id="capacity"
                      placeholder="Time"
                    />
                  </div>

                  <div className="form-group form-check"></div>
                </form>
                <button
                  onClick={saveData}
                  className="btn btn-block btn-outline-primary"
                >
                  ADD TABLE
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default BookTable;
