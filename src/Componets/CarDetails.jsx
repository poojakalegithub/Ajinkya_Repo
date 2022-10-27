import React from 'react'

function CarDetails() {
  const car = {
    model: 'i20',
    company: 'Hyundai',
    price: 20,
    configuration: {
     color: 'gray',
     fuel: 'petrol',
     cylinder: 4,
     fuelTankCapacity: 37,
     mileage: {
     city: 14,
     highway: 20,
     },
     },
    features: ['touch screen', 'bluetooth', 'alloy wheels', 'power steering'],
    }
    
  return (
      <div>
        <h1>Car</h1>
        <hr/>
        <h2>Model: {car.model}</h2>
        <h2>Compony: {car.company}</h2>
        <h2>Price: {car.price}</h2>
        <hr/>
        <h1>Configuration</h1>
        <hr/>
        <h2>Color: {car.configuration.color}</h2>
        <h2>Fuel: {car.configuration.fuel}</h2>
        <h2>Cylinder: {car.configuration.cylinder}</h2>
        <h2>Fuel tank capacity: {car.configuration.fuelTankCapacity}</h2>
        <hr/>
        <h1>Mileage</h1>
        <hr/>
        <h2>City: {car.configuration.mileage.city}</h2>
        <h2>Highway: {car.configuration.mileage.highway}</h2>
        <hr/>
        <h1>Features</h1>
        <hr/>
        <h2><ul>{car.features.map(function(item) {
          return <li key={item}>{item}</li>;
        })}</ul></h2>
      </div>
      
  )
}

export default CarDetails