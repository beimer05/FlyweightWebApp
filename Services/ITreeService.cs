using FlyweightWebApp.Models;

namespace FlyweightWebApp.Services
{
    public interface ITreeService
    {
        IEnumerable<Tree> GetAllTrees();
    }
}
