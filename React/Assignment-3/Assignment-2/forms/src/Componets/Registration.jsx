import React from 'react'
import { useState } from 'react'

const Registration = () => {
 
     
    const [email,setEmail] = useState('')
    const [password,setPassword]= useState('')
    const [name,setName] = useState('')
    const [confirmpassword,setConfirmPassword] = useState('')


    function eraseUser(e){
       e.target.value = ''
    }

    function validateUser(){

        if (password.length >= 5 && confirmpassword == password)
        {
            console.log(`Name is ${name}`);
            console.log(`Email is ${email}`);
            console.log(`Password is ${password}`);
            alert('Login success')
        }
        else {
            alert('please check your password')
        }    
        
        
       
    }

    function readEmail(e)
    {
        setEmail(e.target.value)
    }
    function readPassword(e){
    
        setPassword(e.target.value)
    }

    function readName(e){
        setName(e.target.value)
    }

    function readconfirmPassword(e){
        setConfirmPassword(e.target.value)
    }

  return (

    

    <div>
      
  <h1 className='d-flex justify-content-center' >Registration Form</h1>
        <div className='d-flex justify-content-center align-items-center'>
            <hr />
          
            <hr />

            <form action="">
            <div className='form-group'>
                    <label htmlFor="">User Name</label>
                    <input onChange={readName} type="username" className='form-control'placeholder='Enter Name' />
                </div>
                <div className='form-group'>
                    <label htmlFor="">Email Address</label>
                    <input onChange={readEmail} type="email" className='form-control'placeholder='Enter email' />
                </div>

                <div className='form-group'>
                    <label htmlFor="">Password</label>
                    <input onChange={readPassword} type="password" className='form-control'placeholder='Enter Password' />
                </div>

                <div className='form-group'>
                    <label htmlFor="">Confirm Password</label>
                    <input onChange={readconfirmPassword} type="password" className='form-control'placeholder='Re-Enter Password' />
                </div>

                <div className='form-group form-check'>
                    <input type="checkbox" className='form-check-input'id='exampleCheck1' />
                    <label htmlFor="">check me out</label>
                </div>

                <button onClick={validateUser} type='submit' className='btn btn-primary'>Login</button>
                <span>  </span>
                <button onClick={eraseUser} type='submit' className='btn btn-danger'>Clear</button>
            </form>
        </div>
    </div>
  )
  
}

export default Registration