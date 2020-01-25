using BoxManager.Model;

namespace BoxManager.Controller.BoxController
{
    public interface IBoxController : IController<Box>
    {
        void CreateRandomBox();
    }
}
