using BoxManager.Model;
using BoxManager.Repository.BoxDimensionRepository;
using System.Collections.Generic;

namespace BoxManager.Controller.BoxDimensionController
{
    class BoxDimensionController : IBoxDimensionController
    {
        readonly BoxDimensionRepository _repository;

        public BoxDimensionController(BoxDimensionRepository repository) => _repository = repository;

        public void Change(Box_Dimension dimensions) => _repository.Update(dimensions);
        public void Delete(Box_Dimension dimensions) =>  _repository.Delete(dimensions);
        public void Delete(int Id) => _repository.Delete(Id);
        public Box_Dimension GetById(int Id) => _repository.GetById(Id);
        public IEnumerable<Box_Dimension> GetAll() => _repository.List();
        public void Insert(Box_Dimension dimensions) =>_repository.Insert(dimensions);
    }
}
