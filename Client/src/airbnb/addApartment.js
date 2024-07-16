import React, { useState, useEffect } from "react";

import axios from 'axios';

const AddApartment = () => {
  const [formData, setFormData] = useState({
    country: '',
    city: '',
    street: '',
    aptStyle: '',
    beds: '',
    pricePerNight: ''
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    axios.post('https://localhost:7190/api/AddApartment', formData)
      .then(response => {
        console.log('Apartment added successfully:', response.data);
      })
      .catch(error => {
        console.error('There was an error adding the apartment:', error);
      });
  };

  return (
    <div className="form-container">
      <h1>Add Apartment Page</h1>
      <form className="apartment-form" onSubmit={handleSubmit}>
        <label>
          Country:
          <input type="text" name="country" value={formData.country} onChange={handleChange} />
        </label>
        <label>
          City:
          <input type="text" name="city" value={formData.city} onChange={handleChange} />
        </label>
        <label>
          Street:
          <input type="text" name="street" value={formData.street} onChange={handleChange} />
        </label>
        <label>
          Apartment Style:
          <input type="text" name="aptStyle" value={formData.aptStyle} onChange={handleChange} />
        </label>
        <label>
          Beds:
          <input type="number" name="beds" value={formData.beds} onChange={handleChange} />
        </label>
        <label>
          Price per Night:
          <input type="number" name="pricePerNight" value={formData.pricePerNight} onChange={handleChange} />
        </label>
        <button type="submit">Submit</button>
      </form>
    </div>
  );
};

export default AddApartment;
