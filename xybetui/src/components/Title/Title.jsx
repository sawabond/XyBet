import React from 'react';
import Logo from '../../img/logo.png';
import './Title.scss';

export default function Title() {
  return (
    <div className="title">
      <div className="title__logo">
        <img src={Logo} alt="logo" />
      </div>
    </div>
  );
}
