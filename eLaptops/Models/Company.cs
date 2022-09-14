using System.ComponentModel.DataAnnotations;

namespace eLaptops.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [Display(Name = "Company Logo")]
        public string CompanyLogo { get; set; }
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public List<Laptop> Laptops { get; set; }
    }
}
