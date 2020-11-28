import React from 'react';
import { Marker, Popup } from 'react-leaflet';
import Sensor from '../sidebar/Sensor';

export default function MapMarker(props) {
    return (
        <Marker position={[props.sensor.latitude, props.sensor.longitude]}>
            <Popup>
                <Sensor sensor={props.sensor} />
          </Popup>
        </Marker>
    );
}