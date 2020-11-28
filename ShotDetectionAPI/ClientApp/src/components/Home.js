import React, { useState } from 'react';
import Map from './map/Map';
import Sidebar from './sidebar/Sidebar';
import { Container, Row, Col } from 'reactstrap';
import { useMap } from 'react-leaflet';

export default function Home(props) {
  const [map_center, setMapCenter] = useState([47.497913, 19.040236]);

  const setMapCenterCallback = (latlon) => {
    console.log(latlon);
    setMapCenter(latlon);
  }

  return (
    <Container className="map-container">
      <Row>
        <Col xs="10" className="map-column">
          <Map center={map_center} />
        </Col>
        <Col xs="2" className="sidebar-column">
          <Sidebar mapSetterCallback={setMapCenterCallback} />
        </Col>
      </Row>
    </Container>
  );
}
