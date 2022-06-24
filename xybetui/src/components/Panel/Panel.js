import React from 'react';
import LogoHalf from '../../img/LogoHalf.png';
import './Panel.scss';

export default function Panel() {
  return (
    <div className="panel">
      <div className="panel__logo">
        <img src={LogoHalf} alt="logo" />
      </div>
      <div className="panel__rank">
        <ul>
          <li>
            <p>OFFICIAL</p>
          </li>
          <li>
            <p>BETTING</p>
          </li>
          <li>
            <p>PARTNER</p>
          </li>
        </ul>
      </div>
    </div>
  );
}
