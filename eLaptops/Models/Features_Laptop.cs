namespace eLaptops.Models
{
    public class Features_Laptop
    {
        public int FeatureID { get; set; }
        public Features Features { get; set; }
        public int LaptopID { get; set; }
        public Laptop Laptop { get; set; }
    }
}
