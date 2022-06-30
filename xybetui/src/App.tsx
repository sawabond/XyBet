import React from 'react';
import './App.scss';
import { Route, Routes } from 'react-router-dom';
import Main from './routers/Main/Main';

function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Main />} />
      </Routes>
    </>
  );
}

export default App;
