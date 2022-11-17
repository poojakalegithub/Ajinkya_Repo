import React, {useEffect,useState} from 'react'
import data from "./mock-data.json";

function TableData() {
    const [UserData,setUserData] = useState(data);
         
    return ( 
        <div>
            <UserData userdata = {UserData}/>
        </div>
  )
}

export default  TableData