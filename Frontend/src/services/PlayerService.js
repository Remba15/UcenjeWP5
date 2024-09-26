

async function get(){
    return await HttpService.get('/Player')
    .then((odgovor)=>{
        console.log(odgovor.data)
        console.table(odgovor.data)
    })
    .catch((e)=>console.log(e))
}

export default{
    get
}