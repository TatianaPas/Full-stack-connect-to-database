using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Week5FS.Models
{
    public class Vehicle
    {
        [Key]

        public int VehicleId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        [DisplayName("Year of Manufacture")]
        public int YearOfManufacture { get; set; }
        public string Rego { get; set; }
        public string Color { get; set; }
        [DisplayName("Automatic")]
        public bool isAutomatic { get; set; }
        [DisplayName("Doors")]
        public int NumberOfDoors { get; set; }
        public double Price { get; set; }

    }
}
