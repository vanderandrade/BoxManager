using BoxManager.Model;
using BoxManager.Repository.BoxRepository;
using System.Collections.Generic;

namespace BoxManager.Controller.BoxController
{
    public class BoxController : IBoxController
    {
        readonly BoxRepository _repository;

        public BoxController(BoxRepository repository) => _repository = repository;

        public void Change(Box box) => _repository.Update(box);
        public void Delete(Box box) => _repository.Delete(box);
        public Box GetById(int Id) => _repository.GetById(Id);
        public IEnumerable<Box> GetAll() => _repository.List();
        public void Insert(Box box) => _repository.Insert(box);

        public void CreateRandomBox()
        {
            Box box = new Box() { Label = "Random Box"};
            Insert(box);
        }
    }
}
