using System.ComponentModel.DataAnnotations;

namespace eLaptops.Models
{
    public class Features
    {
        [Key]
        public int FeatureID { get; set; }
        [Display(Name = "Feature Picture")]
        [Required(ErrorMessage = "Feature Picture is required")]
        public string FeaturePictureURL { get; set; }
        [Display(Name = "Feature Name")]
        [Required(ErrorMessage = "Feature Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Feature Name must be between 3 and 50 chars")]
        public string FeatureName { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        //Realtionships
        public List<Features_Laptop> Features_Laptops { get; set; }
    }
}
