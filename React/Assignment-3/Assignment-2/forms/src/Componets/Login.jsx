import React from 'react'
import { useState } from 'react'

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
            alert('Login success')
        }
        else {
            alert('Please enter password')
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
      
  <h1 className='d-flex justify-content-center' >Login Form</h1>
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
                    <input type="checkbox" className='form-check-input'id='exampleCheck1' />
                    <label htmlFor="">Check me out</label>
                </div>

                <button onClick={validateUser} type='submit' className='btn btn-primary'>Login</button>
                <span>  </span>
                <button onClick={eraseUser} type='submit' className='btn btn-danger'>Clear</button>
            </form>
        </div>
    </div>
  )
}

export default Login