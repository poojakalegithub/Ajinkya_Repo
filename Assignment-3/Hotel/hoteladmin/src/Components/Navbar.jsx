import React from "react";
import {Link} from 'react-router-dom';

export const Navbar = () => {


  return (
    <nav class="navbar fixed-top navbar-expand-md navbar-dark bg-dark mb-3">
      <div class="flex-row d-flex">
        <button
          type="button"
          class="navbar-toggler mr-2 "
          data-toggle="offcanvas"
          title="Toggle responsive left sidebar"
        >
          <span class="navbar-toggler-icon"></span>
        </button>
        <Link to ='/'
          class="navbar-brand"
          href="#"
          title="Free Bootstrap 4 Admin Template"
        >
          Villa Hotels
        </Link>
      </div>
      <button
        class="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#collapsingNavbar"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="navbar-collapse collapse" id="collapsingNavbar">
        <ul class="navbar-nav">
          <li class="nav-item active">
          <Link class="nav-link" to="/ListHotels">
              Hotels<span class="sr-only">Hotels</span>
            </Link>
          </li>
          <li class="nav-item active">
            <Link class="nav-link" to="/AddHotel">
              Add Hotels<span class="sr-only">Add Hotels</span>
            </Link>
          </li>
          <li class="nav-item active">
            <Link class="nav-link" to="/SelectHotel">
              Update Hotels<span class="sr-only">Update Hotels</span>
            </Link>
          </li>
          <li class="nav-item active">
            <Link class="nav-link" to="/Bookings">
              Bookings <span class="sr-only">Bookings</span>
            </Link>
          </li>
          <li class="nav-item active">
            <Link class="nav-link" to="/UserList">
              Users <span class="sr-only">Users</span>
            </Link>
          </li>
        </ul>
        <ul class="navbar-nav ml-auto">
          <li class="nav-item">
            <a class="nav-link" href="#myAlert" data-toggle="collapse">
              Admin
            </a>
          </li>
          <li class="nav-item">
            <Link
              class="nav-link"
              to="/Login"
              data-target="#myModal"
              data-toggle="modal"
            >
              Log out
            </Link>
          </li>
        </ul>
      </div>
    </nav>
  );
};
export default Navbar;
