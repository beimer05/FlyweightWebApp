using FlyweightWebApp.Models;
using System.Collections.Concurrent;

namespace FlyweightWebApp.Flyweight
{
    public class TreeFactory
    {
        private readonly ConcurrentDictionary<string, TreeType> _treeTypes = new ConcurrentDictionary<string, TreeType>();

        public TreeType GetTreeType(string name, string color, string iconPath)
        {
            string key = $"{name}-{color}-{iconPath}";

            return _treeTypes.GetOrAdd(key, _ => new TreeType
            {
                Name = name,
                Color = color,
                IconPath = iconPath

            }); // Replace GetOrAdd with direct dictionary access  
        }

        public IEnumerable<TreeType> GetAvailableTypes()
        {
            return _treeTypes.Values;
        }
    }
}
