using FlyweightWebApp.Flyweight;
using FlyweightWebApp.Models;

namespace FlyweightWebApp.Services
{
    public class TreeService : ITreeService
    {

        private readonly TreeFactory _treeFactory;

        public TreeService()
        {
            _treeFactory = new TreeFactory();
        }
        public IEnumerable<Tree> GetAllTrees()
        {
            return new List<Tree>
            {
                new Tree { Latitude = 34.0522, Longitude = -118.2437, Type = _treeFactory.GetTreeType("Oak","Green","~/image/Oak.png") },
                new Tree { Latitude = 34.0522, Longitude = -118.2437, Type = _treeFactory.GetTreeType("Pine","DarkGreen","~/image/Pine.png") },
                new Tree { Latitude = 34.0522, Longitude = -118.2437, Type = _treeFactory.GetTreeType("Maple","Brown","~/image/Maple.png") },
                new Tree { Latitude = 34.0522, Longitude = -118.2437, Type = _treeFactory.GetTreeType("Oak","Green","~/image/Oak.png") },
                new Tree { Latitude = 34.0522, Longitude = -118.2437, Type = _treeFactory.GetTreeType("Pine","DarkGreen","~/image/Pine.png") }
            }
           
        }
    }
}
