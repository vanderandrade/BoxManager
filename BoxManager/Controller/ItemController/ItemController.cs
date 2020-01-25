using BoxManager.Repository.ItemRepository;
using BoxManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxManager.Controller.ItemController
{
    class ItemController : IItemController
    {
        readonly ItemRepository _repository;

        public ItemController(ItemRepository repository) => _repository = repository;

        public void Change(Item item) => _repository.Update(item);
        public void Delete(Item item) => _repository.Delete(item);
        public Item GetById(int Id) => _repository.GetById(Id);
        public IEnumerable<Item> GetAll() => _repository.List();
        public void Insert(Item item) => _repository.Insert(item);
    }
}
