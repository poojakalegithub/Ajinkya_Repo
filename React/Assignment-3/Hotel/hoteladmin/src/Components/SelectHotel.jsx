import React, {useEffect,useState} from 'react'
import data from "./Data/HotelData.json"
import {Link} from 'react-router-dom';


function SelectHotel() {
    const [UserData,setUserData] = useState(data.Hotels);
    const [name, setname] = useState("");
    const [type, settype] = useState("");
    const [price, setprice] = useState(0);
    const [size, setsize] = useState(0);
    const [capacity, setcapacity] = useState(1);
    const [description, setdescription] = useState("");

    useEffect(()=>{
        getUsers()
    },[])

    function getUsers() {
        fetch(`http://localhost:8000/Hotels`).then((result) => {
          result.json().then((resp) => {
            console.warn(resp)
            setUserData(resp)
            setname(resp[0].name)
            settype(resp[0].type)
            setprice(resp[0].price)
            setsize(resp[0].size)
            setcapacity(resp[0].capacity)
            setdescription(resp[0].description)

          })
        })
      }

    // function getlist()
    // {
    //     fetch(`http://localhost:8000/Hotels`).then((result)=>{
    //         result.json().then((resp)=>{
    //             console.warn(resp)
    //             setUserData(resp)
               
    //         })
    //     })
    // }

    function DeleteData(id){
        fetch(`http://localhost:8000/Hotels/${id}`,{
            method:'DELETE'
        }).then((result)=>{
            result.json().then((resp)=>{
                console.warn(resp)
                // getlist()
            })
        })
    }

    function SelectUser(id)
    {
      let item=UserData.Hotels[id-1];
          setname(item.name)
          settype(item.type)
          setprice(item.price)
          setsize(item.size)
          setcapacity(item.capacity)
          setdescription(item.decription)
    }

    function UpdateData()
    {
      let item={name,type,price,size,capacity,description}
      console.warn("item",item)
      fetch(`http://localhost:8000/hotels/${UserData.id}`, {
        method: 'PUT',
        headers:{
          'Accept':'application/json',
          'Content-Type':'application/json'
        },
        body:JSON.stringify(item)
      }).then((result) => {
        result.json().then((resp) => {
          console.warn(resp)
          getUsers()
        })
      })
    }
         
    return (
        <div>
            <h1> Select Hotels </h1>
            <table>
            <thead>
                <tr>
                    <th>Name</th>
                </tr>
            </thead>
            <tbody>
                {UserData.map((userdata) => (
                   <tr>
                    <td>{userdata.id}</td>
                    <td>{userdata.name}</td>
                    <td>
                        <button onClick={() => SelectUser(userdata.id)} className="btn btn-block btn-outline-primary">Select</button>
                    </td>
                    <td>
                        <button onClick={()=>DeleteData(userdata.id)} className="btn btn-block btn-outline-primary">Delete</button>
                    </td>
                   </tr> 
                ))}
            </tbody>
            </table>
            
        
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
                      onChange={(e) => setname(e.target.value)}
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
                      type="text"
                      value={price}
                      onChange={(e) => setprice(e.target.value)}
                      className="form-control"
                      required
                      id="price"
                      placeholder="Hotel price"
                    />
                    <label htmlFor="size">Size</label>
                    <input
                      type="text"
                      className="form-control"
                      value={size}
                      onChange={(e) => setsize(e.target.value)}
                      required
                      id="size"
                      placeholder="Hotel Size"
                    />
                    <label htmlFor="capacity">Capacity</label>
                    <input
                      type="text"
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
                <button onClick={()=>UpdateData(UserData.id)}
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
    </div>
  )
}

export default  SelectHotel