import React from "react";
import "./slider.css";
import { Carousel} from "react-bootstrap/";

import 'bootstrap/dist/css/bootstrap.min.css';
import { CarouselItem } from "react-bootstrap";
import Slider1 from "../../../images/Slider1.jpg"
import Slider2 from "../../../images/Slider2.jpg"
import Slider3 from "../../../images/Slider3.jpg"

const Slider = () => {
  return (
    <div className="slider">
      <Carousel>
  <CarouselItem>
    <img
      className="d-block w-100"
      src={Slider3}
      alt="First slide"
    />

  </CarouselItem>
  <Carousel.Item>
    <img
      className="d-block w-100"
      src={Slider1}
      alt="Second slide"
    />

    
  </Carousel.Item>
  <Carousel.Item>
    <img
      className="d-block w-100"
      src={Slider2}
      alt="Third slide"
    />

    
  </Carousel.Item>
</Carousel>
    </div>
  );
};

export default Slider;
