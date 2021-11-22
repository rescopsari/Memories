import React from "react";

import * as AiIcons from "react-icons/ai";

import "./footer.css";

const Footer = () => {
  return (
    <div className="footer">
      <div className="footer-logos">
        <ul className="footer-list">
          <li>
            <a href="https://www.facebook.com" className="logo-list">
              <AiIcons.AiFillFacebook className="icon light" />
            </a>
          </li>
          <li>
            <a className="logo-list" href="https://www.twitter.com">
              <AiIcons.AiOutlineTwitter className="icon light" />
            </a>
          </li>
          <li>
            <a className="logo-list" href="https://instagram.com">
              <AiIcons.AiFillInstagram className="icon light" />
            </a>
          </li>
        </ul>
      </div>
      <div className="footer-description">
        <h2>Memories</h2>
        <div className="contact-tel-footer">
          <h3 className="title-contact-footer">
            <AiIcons.AiFillPhone />
            Téléphone
          </h3>
          <p className="description-contact-footer">05.56.00.01.02</p>
        </div>
        <div className="contact-email-footer">
          <h3 className="title-contact-footer">
            <AiIcons.AiFillMail />
            Email
          </h3>
          <p className="description-contact-footer">memories@gmail.com</p>
        </div>
      </div>
    </div>
  );
};

export default Footer;
