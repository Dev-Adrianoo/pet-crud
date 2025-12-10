using Microsoft.AspNetCore.Mvc;


namespace PetCrud.Controler;

[ApiController]
[Route("api/[controller]")]
public class PetController : ControllerBase
{


    [HttpGet]
    public IActionResult GetPets()
    {
        return Ok(new List<string> {"Rex", "Luna", "Bolt"});
    }

    [HttpPost]
    public IActionResult CreatePet([FromBody] string name)
    {
        return Created ("", $"Pet criado: {name}");
    }


    [HttpGet("{id}")]
    public IActionResult GetPet(int id)
    {
        return Ok ($"Buscar um pet: {id}");
    }


    [HttpPut("{id}")]
    public IActionResult UpdatePet(int id)
    {
        return Ok($"Pet com id: {id} atualizado");
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePet(int Id)
    {
        return Ok("pet Deletado");
    }

}


