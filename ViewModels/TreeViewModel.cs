using System.ComponentModel.DataAnnotations;

namespace FlyweightWebApp.ViewModels
{
    public class TreeViewModel
    {
        [Required(ErrorMessage = "Species is required")]
        public string Species { get; set; }

        [Required(ErrorMessage = "Latitude is required")]
        public double? Latitude { get; set; }

        [Required(ErrorMessage = "Longitude is required")]
        public double? Longitude { get; set; }
        public List<string> AvailableSpecies { get; set; }

    }
}
