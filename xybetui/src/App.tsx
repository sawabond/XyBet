import React from 'react';
import './App.scss';
import { Route, Routes } from 'react-router-dom';
import Main from './routers/Main/Main';
import MyBets from './routers/MyBets/MyBets';

function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Main />} />
        <Route path="/my-bets" element={<MyBets />} />
      </Routes>
    </>
  );
}

export default App;
