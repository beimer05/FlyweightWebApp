using FlyweightWebApp.Models;

namespace FlyweightWebApp.Flyweight
{
    public class TreeFactory
    {
        private readonly Dictionary<string, TreeType> _treeType = new Dictionary<string, TreeType>();
        public TreeType GetTreeType(string name, string color, string iconPath)
        {
            var key = $"{name}-{color}-{iconPath}";
            if (!_treeType.ContainsKey(key))
            {
                _treeType[key] = new TreeType
                {
                    Name = name,
                    Color = color,
                    IconPath = iconPath
                };
            }
            return _treeType[key];
        }
    }
}
