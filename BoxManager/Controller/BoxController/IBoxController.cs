using BoxManager.Model;
using System.Collections.Generic;

namespace BoxManager.Controller.BoxController
{
    public interface IBoxController : IController<Box>
    {
        void CreateRandomBox();
        IList<Item> GetAllItems(int Id);
        IList<Item> GetAllItems(Box box);
    }
}
