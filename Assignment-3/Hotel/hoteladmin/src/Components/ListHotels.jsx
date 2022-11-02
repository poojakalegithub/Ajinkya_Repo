import React, {useEffect,useState} from 'react'
import data from "./Data/HotelData.json"


function Table() {
    const [UserData,setUserData] = useState(data);
         
    return (
        <div>
            <h1> Hotels </h1>
            <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Type</th>
                    <th>Size</th>  
                    <th>Price</th>  
                    <th>Capacity</th>
                    <th>Pets</th>
                    <th>Breakfast</th>
                    <th>Description</th>   
                </tr>
            </thead>
            <tbody>
                {UserData.map((userdata) => (
                   <tr>
                    <td>{userdata.name}</td>
                    <td>{userdata.type}</td>
                    <td>{userdata.price}</td>
                    <td>{userdata.size}</td>
                    <td>{userdata.capacity}</td>
                    <td>{userdata.pets}</td>
                    <td>{userdata.breakfast}</td>
                    <td>{userdata.description}</td>
                   </tr> 
                ))}
            </tbody>
            </table>
            
        </div>
  )
}

export default  Table