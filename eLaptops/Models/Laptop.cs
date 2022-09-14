using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eLaptops.Models
{
    public class Laptop
    {
        [Key]
        public int LaptopID{ get; set; }
        public string ModelName { get; set; }
        public string ScreenSize { get; set; }
        public string Colour { get; set; }
        public string CPUModel { get; set; }
        public string RAM { get; set; }
        public string OperatingSystem { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }

        //Relationships
        public List<Features_Laptop> Features_Laptops { get; set; }

        //Company
        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Company Company { get; set; }
    }
}
