using PetCrud.Repository;

namespace PetCrud.service;
public class PetService
{
    private readonly PetRepository _petRepository;

    public PetService(PetRepository petRepository)
    {
        _petRepository = petRepository;
    }

    public string Test()
    {
        return "teste";
    }
    
}