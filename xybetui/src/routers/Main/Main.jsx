import React from 'react';
import BoardMatches from '../../components/BoardMatches/BoardMatches';
import Panel from '../../components/Panel/Panel';
import PanelCoeff from '../../components/PanelCoeff/PanelCoeff';
import Title from '../../components/Title/Title';

export default function Main() {
  return (
    <div className="wrapper">
      <Title />
      <Panel />
      <PanelCoeff />
      <BoardMatches />
    </div>
  );
}
