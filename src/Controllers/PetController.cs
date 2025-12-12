using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using PetCrud.service;


namespace PetCrud.Controler;

[ApiController]
[Route("api/[controller]")]
public class PetController : ControllerBase
{
    private readonly PetService _petService;

    public PetController(PetService petService)
    {
         _petService = petService;
    }    

    [HttpGet]
    public IActionResult GetPets()
    {
        return Ok(new List<string> {"Rex", "Luna", "Bolt", "Pedro"});
    }

    [HttpPost]
    public IActionResult CreatePet([FromBody] string  name)
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


