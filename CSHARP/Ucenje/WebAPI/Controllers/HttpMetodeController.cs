using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {

        //Ovdje pocinje ruta
        [HttpGet]
        public string Pozdravi()
        {
            return "Hello world.";
        }
        //Ovdje zavrsva ruta

        //Ovdje pocinje ruta
        [HttpGet]
        [Route("Pozdravi")]
        public string Pozdravi(string ime)
        {
            return "Hello " + ime;
        }
        //Ovdje zavrsava ruta

        //Kreirajte rutu naziva Zbroj koja prima dva cijela broja i vraća nazad njihov zbroj.
        //Pocinje ruta
        [HttpGet]
        [Route("Zbroj")]
        public int Zbroj(int broj1, int broj2)
        {
            return broj1 + broj2;
        }
        //Zavrsava ruta


        //Pocinje ruta
        [HttpGet]
        [Route("Hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new { id = id, ime = ime });
        }
        //Zavrsva ruta

        //Pocinje ruta
        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest(new { greska = true, poruka = "Nešto ne valja" });
        }
        //Zavrsava metoda


        //Pocinje ruta

        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { greska = true, poruka = "Nije dobar parametar" });
            }
            osoba.Prezime = "g. " + osoba.Prezime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }
        //Zavrsava ruta

        //Pocinje ruta

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return NotFound(new { id = id, poruka = "Ne mogu pronaći", greska = true });
        }

        //Zavrsava ruta
    }
}
