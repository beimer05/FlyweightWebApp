using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Components.RenderTree;

namespace FlyweightWebApp.Models
{
    public class Tree
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public TreeType Type { get; set; }
    }
}
