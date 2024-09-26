import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import Container from 'react-bootstrap/Container';
import NavBarEdunova from './components/NavBarEdunova';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constants';
import pocetna from './pages/pocetna';
import PlayersView from './pages/Players/PlayersView';


function App() {

  return (
    <>
    <Container>
        <NavBarEdunova/>
        <Routes>
          <Route path={RouteNames.HOME} element={<pocetna/>}/>
          <Route path={RouteNames.PLAYERS_VIEW} element={<PlayersView/>}/>
        </Routes>
    </Container>

    </>
  )
}

export default App
