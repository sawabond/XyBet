import React from "react";
import Bet from "../../contracts/Bet";

export default function BetCard(props: any) {
  return (
    <div>
      <ul>
        <li>{props.bet.id}</li>
        <li>{props.bet.userId}</li>
        <li>{props.bet.betSum}</li>
        <li>{props.bet.betResult}</li>
      </ul>
    </div>
  );
}
