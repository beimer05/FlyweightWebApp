using FlyweightWebApp.Models;

namespace FlyweightWebApp.Services
{
    public interface ITreeService
    {
        void AddTree(string species, double latitude, double longitude);
        List<Tree> GetAllTrees();
        List<string> GetAvailableSpecies();
    }
}
