import React from 'react';
import './PanelCoeff.scss';
import LogoTournament from '../../img/logo-tourn.png';
export default function PanelCoeff() {
  return (
    <div className="panelcoeff">
      <div className="panelcoeff__title-tournament">
        <img src={LogoTournament} alt="logo" />
        <p>Stockholm Major</p>
      </div>
      <div className="panelcoeff__list">
        <ul>
          <li>1</li>
          <li>X</li>
          <li>2</li>
          <li>1X</li>
          <li>12</li>
          <li>2X</li>
          <li>Б</li>
          <li>ТОТАЛ</li>
          <li>M</li>
        </ul>
      </div>
    </div>
  );
}
