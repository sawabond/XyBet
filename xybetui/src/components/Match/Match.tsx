import React from 'react';
import './Match.scss';
import Furia from '../../img/furia-logo.png';
import Heroic from '../../img/heroic-logo.png';

export default function Match() {
  return (
    <div className="match">
      <div className="match__time">
        <p>17:30</p>
        <p>19:00</p>
      </div>
      <div className="match__teams">
        <p>Furia</p>
        <p>Heroic</p>
      </div>
      <div className="match__logos">
        <img src={Furia} alt="furia" />
        <img src={Heroic} alt="heroic" />
      </div>
      <div className="match__list-coeff">
        <ul>
          <li>2.325</li>
          <li>3.35</li>
          <li>3.32</li>
          <li>1.335</li>
          <li>1.335</li>
          <li>1.616</li>
          <li>1.991</li>
          <li>2.5</li>
          <li>1.873</li>
        </ul>
      </div>
    </div>
  );
}
