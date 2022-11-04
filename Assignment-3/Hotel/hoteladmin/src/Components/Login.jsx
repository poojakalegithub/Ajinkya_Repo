import React from 'react'
import { useState } from 'react'
import {Link} from 'react-router-dom'

const Login = () => {


   

    const [email,setEmail] = useState('')
    const [password,setPassword]= useState('')


    function eraseUser(e){
       e.target.value = ''
    }

    function validateUser(){

        if (password.length >= 5)
        {
            console.log(`Email is ${email}`);
            console.log(`Password is ${password}`);
            alert('Login success');
            
            
        }
        else {
            alert('Password length should greater than 5')
        }    
        
        
       
    }

    function readEmail(e)
    {
        setEmail(e.target.value)
    }
    function readPassword(e){
    
        setPassword(e.target.value)
    }

  return (
    
    <div>
      <h1 className='d-flex justify-content-center' >Login </h1>
        <div className='d-flex justify-content-center align-items-center'>
            <hr />
          
            <hr />

            <form action="">
                <div className='form-group'>
                    <label htmlFor="">Email Address:</label>
                    <input onChange={readEmail} type="email" className='form-control'placeholder='Enter email' />
                </div>

                <div className='form-group'>
                    <label htmlFor="">Password:</label>
                    <input onChange={readPassword} type="password" className='form-control'placeholder='Enter Password' />
                </div>

                <div className='form-group form-check'>
                    <label htmlFor="">Not Register ? <Link class="nav-link" to="/Registration"> SignUp </Link></label>
                </div>

                <Link class="nav-link" to="/ListHotels">
                <button onClick={validateUser} type='submit' className='btn btn-primary'>
                Login</button></Link>
                {/* <button onClick={eraseUser} type='submit' className='btn btn-danger'>Clear</button> */}
            </form>
        </div>
    </div>
  )
}

export default Login