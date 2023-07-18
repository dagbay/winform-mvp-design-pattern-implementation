using System.Collections.Generic;

namespace CRUDWinFormsMVP.Models
{
    public interface IPetRepository
    {
        void Add(PetModel petModel);
        void Edit(PetModel petModel);
        void Update(PetModel petModel);
        void Delete(PetModel petModel);
        IEnumerable<PetModel> GetAll();
        IEnumerable<PetModel> GetByValue(string value); // Searches
    }
}