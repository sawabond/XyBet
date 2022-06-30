import React from 'react';
import LogoHalf from '../../img/LogoHalf.png';
import NaviLogo from '../../img/navi-logo.png';
import Live from '../../img/live.png';
import Refresh from '../../img/refresh.png';
import './Panel.scss';

export default function Panel() {
  return (
    <div className="panel">
      <div className="panel__present">
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
        <div className="panel__bet">
          <p>BET</p>
          <p>BETS</p>
        </div>
        <div className="panel__info_favteam">
          <p>Сегодня играет ваша любимая команда</p>
          <img src={NaviLogo} alt="team-logo" />
        </div>
        <div className="panel__live">
          <button>
            <img src={Live} alt="Live" />
          </button>
        </div>
        <div className="panel__refresh">
          <button>
            <img src={Refresh} alt="refresh" />
          </button>
        </div>
      </div>
      <div className="panel__functional">
        <div className="panel__language">
          <select name="language">
            <option value="Ukraine">Українська</option>
            <option value="English">English</option>
            <option value="Russian">Русский</option>
          </select>
        </div>
        <div className="panel__auth">
          <button>Вход</button>
        </div>
      </div>
    </div>
  );
}
