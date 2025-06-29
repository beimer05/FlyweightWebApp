using FlyweightWebApp.Flyweight;
using FlyweightWebApp.Models;

namespace FlyweightWebApp.Services
{
    public class TreeService : ITreeService
    {

        private readonly TreeFactory _treeFactory;
        private readonly List<Tree> _trees = new List<Tree>();

        private readonly Dictionary<string,(string color,string iconPath)> _speciesCatalog = new Dictionary<string, (string color, string iconPath)>
        {
            { "Oak", ("Green", "~/image/Oak.png") },
            { "Pine", ("DarkGreen", "~/image/Pine.png") },
            { "Maple", ("Brown", "~/image/Maple.png") }
        };

        public TreeService()
        {
            _treeFactory = new TreeFactory();
            foreach(var species in _speciesCatalog)
            {
                _treeFactory.GetTreeType(species.Key, species.Value.color, species.Value.iconPath);
            }
        }

        public void AddTree(string species, double latitude, double longitude)
        {
           if(!_speciesCatalog.ContainsKey(species)) throw new ArgumentException($"Species {species} is not recognized.");
            var (color, iconPath) = _speciesCatalog[species];
            var type = _treeFactory.GetTreeType(species, color, iconPath);
            _trees.Add(new Tree
            {
                Latitude = latitude,
                Longitude = longitude,
                Type = type
            });

        }

    

        public List<string> GetAvailableSpecies() => _speciesCatalog.Keys.ToList();

        public List<Tree> GetAllTrees() => _trees;  
         
    }
}
