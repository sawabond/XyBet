import React from 'react';
import Match from '../Match/Match';
import './BoardMatches.scss';

export default function BoardMatches() {
  return (
    <div className="boardmatches">
      <Match />
      <Match />
      <Match />
      <Match />
    </div>
  );
}
