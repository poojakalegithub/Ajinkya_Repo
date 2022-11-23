import React from 'react'

function CarDetailsProps(props) {

  return (
    <div>
        <h1>Car</h1>
        <hr/>
        <h2>Model: {props.model}</h2>
        <h2>Compony: {props.company}</h2>
        <h2>Price: {props.price}</h2>
        <hr/>
        <h1>Configuration</h1>
        <hr/>
        <h2>Color: {props.color}</h2>
        <h2>Fuel: {props.fuel}</h2>
        <h2>Cylinder: {props.cylinder}</h2>
        <h2>Fuel tank capacity: {props.fuelTankCapacity}</h2>
        <hr/>
        <h1>Mileage</h1>
        <hr/>
        <h2>City: {props.city}</h2>
        <h2>Highway: {props.highway}</h2>
        <hr/>
        <h1>Features</h1>
        <hr/>
        <h2><ul>{props.features.map(function(item) {
          return <li key={item}>{item}</li>;
        })}</ul></h2> 
    </div>
  )
}

export default CarDetailsProps