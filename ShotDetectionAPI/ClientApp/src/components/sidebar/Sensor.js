import React from 'react';
import { ListGroupItem } from 'reactstrap';
import { Container, Row, Col } from 'reactstrap';

export default function Sensor(props) {

    const handleClick = () => {
        props.mapSetterCallback([props.sensor.latitude, props.sensor.longitude]);
    }

    return (
        <div className="sensor" onClick={handleClick}>
            <ListGroupItem>
                <Container>
                    <Row>
                        <Col>
                            <h4>
                                ID:
                            </h4>
                        </Col>
                        <Col>
                            <h1>
                                {props.sensor.id}
                            </h1>
                        </Col>
                    </Row>
                    <Row>
                        <Col>
                            <h6>
                                Latitude:
                    </h6>
                        </Col>
                        <Col>
                            <h5>
                                {props.sensor.latitude}
                            </h5>
                        </Col>
                        <Col>
                            <h6>
                                Longitude:
                    </h6>
                        </Col>
                        <Col>
                            <h5>
                                {props.sensor.longitude}
                            </h5>
                        </Col>
                    </Row>
                </Container>
            </ListGroupItem>
        </div>
    );
}