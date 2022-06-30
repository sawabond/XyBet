import React from "react";
import Bet from "../../contracts/Bet";
import { BetResult } from "../../contracts/BetResult";
import "./BetCard.scss";

export default function BetCard(props: any) {
  return (
    <div className="bet-card">
      <div>
        <ul>
          <h3>Bet #{props.bet.id}</h3>
          <li>Sum: {props.bet.betSum}</li>
          <li>Result: {BetResult[props.bet.result]}</li>
        </ul>
      </div>
    </div>
  );
}
