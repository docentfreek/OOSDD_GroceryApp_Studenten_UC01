using GroceryApp.Data.DAL.Repositories;
using GroceryApp.Models.Models;

namespace GroceryApp.Services
{
    public class GroceryListService : IService<GroceryList>
    {
        private readonly GroceryListRepository groceryRepository;
        public GroceryListService()
        {
            groceryRepository = new();
        }
        public List<GroceryList> GetAll()
        {
            return groceryRepository.GetAll();
        }
        public GroceryList Add(GroceryList item)
        {
            throw new NotImplementedException();
        }

        public GroceryList? Delete(GroceryList item)
        {
            throw new NotImplementedException();
        }

        public GroceryList? Get(int id)
        {
            throw new NotImplementedException();
        }

        public GroceryList? Update(GroceryList item)
        {
            throw new NotImplementedException();
        }
    }
}
