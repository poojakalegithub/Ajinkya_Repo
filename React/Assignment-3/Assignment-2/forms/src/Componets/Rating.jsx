import React from 'react'
import { useState } from 'react'
import image from '../Componets/images/star.jpg'

const Rating = () => {


    
  let [counter,setCounter] = useState(0)
  let [star,setRating] = useState([])

  const incrementCounter=()=>{

    if (counter<5)
    {
      setCounter(counter = counter+1)

    
      setRating((counter)=>{
        let incrementarr = [...star]
        incrementarr.push(counter)
        return (incrementarr)
        
      })  
    }

     

  }
  const decrementCounter=()=>{

    if (counter > 0)
    {
      setCounter(counter = counter-1)

      setRating(()=>{
        const decrementarr =[...star]
        decrementarr.pop()
        return(decrementarr)
    
      })
    }
    
  
  }

  
  


  return (
    <div className="container my-5">
        <div className="card text-center my-5">
          <div className="card-body">
            <h1>Rating Component</h1>

            {
                star.map(()=>{
                    return (
                        <>
                        <img src={image}style={{height:'50px',width:'55px'}} alt="image of a star" />
                        </>
                    )
                })
            }
           
          </div>
        </div>

        <span className='mx-5'></span>  
        <button onClick={incrementCounter} className='btn btn-success mx-3'>Increment</button>
            

        <button onClick={decrementCounter} className='btn btn-danger '>decrement</button>
            

        


      </div>
  )
}

export default Rating