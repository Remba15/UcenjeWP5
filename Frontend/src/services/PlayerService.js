import {HttpService} from "./HttpService"

async function get(){
    return await HttpService.get('/Player')
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Problem kod dohvaćanja igrača'}
    })
}

async function brisanje(sifra){
    return await HttpService.delete('/Player/' + sifra)
    .then(()=>{
        return {greska: false, poruka: 'Obrisano'}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Problem kod brisanja igrača'}
    })
}

export default{
    get,
    brisanje
}