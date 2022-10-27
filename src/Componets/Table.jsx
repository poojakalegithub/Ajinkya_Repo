import React, {useEffect,useState} from 'react'
import data from "./mock-data.json";

function Table() {
    const [UserData,setUserData] = useState(data);
         
    return (
        <div>
            <h1> Table </h1>
            <table>
            <thead>
                <tr>
                    <th>UserId</th>
                    <th>Id</th>  
                    <th>Title</th>  
                    <th>Body</th>   
                </tr>
            </thead>
            <tbody>
                {UserData.map((userdata) => (
                   <tr>
                    <td>{userdata.userId}</td>
                    <td>{userdata.id}</td>
                    <td>{userdata.title}</td>
                    <td>{userdata.body}</td>
                   </tr> 
                ))}
            </tbody>
            </table>
            
        </div>
  )
}

export default  Table