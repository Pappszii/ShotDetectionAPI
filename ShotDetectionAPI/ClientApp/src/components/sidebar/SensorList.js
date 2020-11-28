import React, { useEffect, useState } from 'react';
import { ListGroup } from 'reactstrap';
import axios from 'axios';
import Sensor from './Sensor.js';

export default function SensorList(props) {
    const [sensors, setSensors] = useState([]);

    useEffect(() => {
        let url = `api/sensors`;
        axios.get(url)
            .then(res => {
                console.log("Get sensors");
                console.log(res.data);
                setSensors(res.data);
            })
            .catch(err => {
                console.log(err);
                console.log("Error while loading sensors");
            });
    }, []);

    return (
        <div className="sensorList">
            <h1>Sensors</h1>
            <ListGroup>
                {sensors.map((sensor, key) => (
                    <Sensor key={key} sensor={sensor} mapSetterCallback={props.mapSetterCallback} />
                ))}
            </ListGroup>
        </div>
    );
}