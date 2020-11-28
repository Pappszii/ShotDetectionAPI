import React from 'react';
import SensorList from './SensorList';

export default function Sidebar(props) {
    return (
        <SensorList mapSetterCallback={props.mapSetterCallback} />
    );
}