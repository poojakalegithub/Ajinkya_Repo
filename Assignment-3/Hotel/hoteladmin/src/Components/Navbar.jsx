import React from "react";

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
        <a
          class="navbar-brand"
          href="#"
          title="Free Bootstrap 4 Admin Template"
        >
          Villa Hotels
        </a>
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
          <a class="nav-link" href="/AddHotel">
              Home <span class="sr-only">Home</span>
            </a>
          </li>
          <li class="nav-item active">
            <a class="nav-link" href="/AddHotel">
              Hotels<span class="sr-only">Hotels</span>
            </a>
          </li>
          <li class="nav-item active">
            <a class="nav-link" href="#">
              Booking <span class="sr-only">Booking</span>
            </a>
          </li>
          <li class="nav-item active">
            <a class="nav-link" href="#">
              Users <span class="sr-only">Users</span>
            </a>
          </li>
        </ul>
        <ul class="navbar-nav ml-auto">
          <li class="nav-item">
            <a class="nav-link" href="#myAlert" data-toggle="collapse">
              Admin
            </a>
          </li>
          <li class="nav-item">
            <a
              class="nav-link"
              href="./Login.jsx"
              data-target="#myModal"
              data-toggle="modal"
            >
              Log out
            </a>
          </li>
        </ul>
      </div>
    </nav>
  );
};
export default Navbar;
