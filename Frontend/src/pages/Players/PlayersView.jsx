import { useEffect } from "react"
import PlayerService from "../../services/PlayerService"


export default function PlayersView(){

    async function getPlayers(){
        await PlayerService.get();
    }

    useEffect(()=>{
        getPlayers();
    },[])


    return(
        <>
        Players View
        </>
    )
}