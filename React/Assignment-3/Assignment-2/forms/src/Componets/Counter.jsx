import React from 'react'
import { useState } from 'react'

const Counter = () => {

  let [counter,setCounter] = useState(0)

  const incrementCounter=()=>{
    setCounter(counter = counter+1)
  }
  const decrementCounter=()=>{
    setCounter(counter = counter-1)
  }

  const resetCounter=()=>{
    setCounter(counter = 0)
  }

  return (
      <div className="container my-5">
        <div className="card text-center my-5">
          <div className="card-body">
            <h1>Counter App</h1>

            <h2>{counter}</h2>

            <button onClick={incrementCounter} className='btn btn-success mx-3'>Increment</button>
            

            <button onClick={decrementCounter} className='btn btn-danger '>decrement</button>
            

            <button onClick={resetCounter}  className='btn btn-secondary mx-3'>reset</button>

          </div>
        </div>
      </div>
  )
}

export default Counter