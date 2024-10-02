import { useEffect, useState } from "react"
import PlayerService from "../../services/PlayerService"
import { Button, Table } from "react-bootstrap";
import moment from "moment";
import { RouteNames } from "../../constants"
import { Link } from "react-router-dom";


export default function PlayersView(){

    const[players, setPlayers] = useState();

    async function getPlayers(){
        const odgovor = await PlayerService.get();
        if(odgovor.greska){
            alert(odgovor.poruka)
            return
        }
        setPlayers(odgovor.poruka);
    }
    

    //Ovaj hook se izvodi dolaskom na stranicu Players
    useEffect(()=>{
        getPlayers();
    },[])

    function formatirajDatum(datum){
        if(datum==null){
            return 'Nije definiran';
        }
        return moment.utc(datum).format('DD. MM. YYYY.')
    }

    //nemam u svom backendu ali pisem za vjezbu
    function formatirajVaucer(v){
        if(v==null) return 'gray'
        if(v) return 'green'
        return 'red'
    }

    function obrisi(sifra){
        if(!confirm('Sigurno obrisati?')){
            return
        }
        deletePlayer(sifra);
    }

    async function deletePlayer(sifra){
        const odgovor = await PlayerService.brisanje(sifra);
        if(odgovor.greska){
            alert(odgovor.poruka)
            return
        }
        getPlayers();
    }

    return(
        <>
        <Link to={RouteNames.PLAYERS_ADD}
        className="btn btn-success siroko">Add new player</Link>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Username</th>
                    <th>Registration Date</th>
                    <th>Region</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                {players && players.map((player, index)=>(
                    <tr key={index}>
                        <td className={player.username==null ? 'sredina' : 'desno'}>
                            {player.username==null ? 'Nije definirano' : player.username}
                        </td>
                        <td className={player.registrationDate==null ? 'sredina' : 'desno'}>
                            {formatirajDatum(player.registrationDate)}
                        </td>
                        <td className={player.region==null ? 'sredina' : 'desno'}>
                        {player.region==null ? 'Nije definirano' : player.region}
                        </td>
                        <td>
                            <Button
                            variant="danger"
                            onClick={()=>obrisi(player.id)}>
                                
                                Delete
                            </Button>
                        </td>
                    </tr>
                ))}
            </tbody>
        </Table>
        </>
    )
}