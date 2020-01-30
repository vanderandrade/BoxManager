using BoxManager.Model;
using BoxManager.Repository.ItemToyRepository;
using System.Collections.Generic;

namespace BoxManager.Controller.ItemToyController
{
    class ItemToyController : IItemToyController
    {
        readonly ItemToyRepository _repository;

        public ItemToyController(ItemToyRepository repository) => _repository = repository;

        public void Change(Item_Toy toy) => _repository.Update(toy);
        public void Delete(Item_Toy toy) => _repository.Delete(toy);
        public void Delete(int Id) => _repository.Delete(Id);
        public Item_Toy GetById(int Id) => _repository.GetById(Id);
        public IEnumerable<Item_Toy> GetAll() => _repository.List();
        public void Insert(Item_Toy toy) => _repository.Insert(toy);
    }
}
