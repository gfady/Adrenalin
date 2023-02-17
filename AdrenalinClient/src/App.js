import './App.css';
import Navbar from './components/Navbar/Navbar';
import SchedulePage from './pages/SchedulePage';
import AboutPage from './pages/AboutPage';
import ServicesPage from './pages/ServicesPage';
import { Route, Routes } from 'react-router-dom';
import NotFound from './pages/NotFound';
import './index.css';
import Header from './components/Header/Header';
import NewsPage from './pages/NewsPage';
import RulesPage from './pages/RulesPage';
import Footer from './components/Footer/Footer';
import { Context } from './Context.js';
import { useState } from 'react';

function App() {
  const [context, setContext] = useState('Минске');
  return (
    <Context.Provider value={[context, setContext]}>
      <div className="App">
        <Header></Header>
        <Navbar></Navbar>
        <Routes>
          <Route path="/about" element={<AboutPage></AboutPage>}></Route>
          <Route
            path="/schedule"
            element={<SchedulePage></SchedulePage>}
          ></Route>
          <Route path="/news" element={<NewsPage></NewsPage>}></Route>
          <Route
            path="/lessons"
            element={<SchedulePage></SchedulePage>}
          ></Route>
          <Route path="/rules" element={<RulesPage></RulesPage>}></Route>
          <Route
            path="/services"
            element={<ServicesPage></ServicesPage>}
          ></Route>
          <Route
            path="/vacancies"
            element={<ServicesPage></ServicesPage>}
          ></Route>
          <Route path="*" element={<NotFound />}></Route>
        </Routes>
        <Footer></Footer>
      </div>
    </Context.Provider>
  );
}

export default App;
