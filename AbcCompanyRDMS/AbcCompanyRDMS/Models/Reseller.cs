using System.ComponentModel.DataAnnotations;

namespace AbcCompanyRDMS.Models
{
    public class Reseller
    {
        [Key]
        public int ResellerId { get; set; }
        public string ResellerName { get; set; }
        public string ResellerAddress { get; set; }
        public string ResellerEmail { get; set; }
        public string ResellerPhone { get; set; }
        public string ResellerContactPerson { get; set; }
        public string ResellerContactPersonPhone { get; set; }

    }
}
