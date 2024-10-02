import { useEffect, useState } from "react"
import PlayerService from "../../services/PlayerService"
import { Button, Table } from "react-bootstrap";
import moment from "moment";


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
        brisanjePlayera(sifra);
    }

    async function brisanjePlayera(sifra){
        
    }

    return(
        <>
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
                                onClick={()=>obrisi(smjer.sifra)}>
                                    
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