import React, { useState, useEffect } from 'react';
import { MapContainer, TileLayer, useMap } from 'react-leaflet';
import MapMarker from './MapMarker';
import axios from 'axios';

export default function Map(props) {
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
        <MapContainer center={props.center} zoom={13} scrollWheelZoom={true} lastCenter={props.center}>
            <TileLayer
                attribution='&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
                url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
            />
            {sensors.map((sensor, key) => (
                <MapMarker key={key} sensor={sensor} />
            ))}
            <MapController />
        </MapContainer>
    );
}

function MapController(props) {
    const map = useMap();

    console.log(map);

    return (
        <></>
    );
}