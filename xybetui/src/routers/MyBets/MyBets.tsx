import axios from "axios";
import { useEffect, useState } from "react";
import BetCard from "../../components/BetCard/BetCard";
import Panel from "../../components/Panel/Panel";
import Title from "../../components/Title/Title";
import Bet from "../../contracts/Bet";

export default function MyBets() {
  const [bets, setBets] = useState<Bet[]>([]);

  function getBets() {
    axios.get<Bet[]>("https://localhost:5001/api/bet/dummy").then((response) => {
      console.log(response.data);
      setBets(response.data);
    });
  }

  useEffect(() => {
    getBets();
  }, []);

  return (
    <div className="wrapper">
      <Title />
      <Panel />
      {bets.map(bet => <BetCard bet={bet}/>)}
    </div>
  );
}
