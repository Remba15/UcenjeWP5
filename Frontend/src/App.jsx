import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import Container from 'react-bootstrap/Container';
import NavBarEdunova from './components/NavBarEdunova';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constants';
import Pocetna from './pages/pocetna';
import PlayersView from './pages/Players/PlayersView';
import PlayersAdd from './pages/Players/PlayersAdd';


function App() {

  return (
    <>
    <Container>
        <NavBarEdunova/>
        <Routes>
          <Route path={RouteNames.HOME} element={<Pocetna/>}/>
          <Route path={RouteNames.PLAYERS_VIEW} element={<PlayersView/>}/>
          <Route path={RouteNames.PLAYERS_ADD} element={<PlayersAdd/>}/>
        </Routes>
    </Container>

    </>
  )
}

export default App
