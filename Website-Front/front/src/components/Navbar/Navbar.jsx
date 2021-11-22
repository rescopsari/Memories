import React, { useState } from "react";
import "./navbar.css";
import Logo from "../../images/logo.png"
import * as AiIcons from "react-icons/ai";
import * as MdIcons from "react-icons/md";
import * as IoIcons from "react-icons/io";
import * as BiIcons from "react-icons/bi";
import { Link } from "react-router-dom";

const Navbar = () => {

    const [navbar, setNavbar] = useState(false)


    const isActive = () => {
        setNavbar(!navbar)
    }


  return (
    <header className="header">
    <div className="navbar">
         <div className="navbar__logo">
           <Link to="/" >
          <img src={Logo} alt="logo" className="navbar__logo-img" />
        </Link>
        </div>
      <nav className={navbar ? "navbar__active" : "navbar__global"}>
       
        <ul className="navbar__list">
          <li className="navbar__item">
            <Link to="/" className="navbar__link" onClick={isActive}>
              <AiIcons.AiFillHome  className="navbar__link-icon" /> Accueil
            </Link>
          </li>
          <li className="navbar__item">
            <Link to="/about" className="navbar__link" onClick={isActive}>
              <MdIcons.MdDescription className="navbar__link-icon" />A propos
            </Link>
          </li>
          <li className="navbar__item">
            <Link to="contact" className="navbar__link" onClick={isActive}>
              <IoIcons.IoIosContact onClick={isActive} className="navbar__link-icon" />
              Contact
            </Link>
          </li>
          <li className="navbar__item">
            <Link to="/connexion" className="navbar__link" onClick={isActive}>
              <BiIcons.BiLogIn className="navbar__link-icon" /> Connexion
            </Link>
          </li>
          <div className="navbar__close">
            <AiIcons.AiOutlineClose onClick={isActive} className="close__icon" />
          </div>
        </ul>
        
      </nav>
      <div className="navbar__burger">
          <AiIcons.AiOutlineMenu onClick={isActive} className="burger__icon"/>
      </div>
    </div>
    </header>
  );
};

export default Navbar;
