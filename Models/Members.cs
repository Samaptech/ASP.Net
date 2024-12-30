using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace ASP.Net.Models
{
    public class Members
    {
        [Key]
        public int Member_Id { get; set; }
        [Required]
        [StringLength(255)]

        public string Member_Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Member_Description { get; set; }

        [Required]
        [StringLength(255)]

        public string Member_Type { get; set; }
        [Required]
        [StringLength(255)]
        [DataType(DataType.PhoneNumber)]

        public string Member_Phone { get; set; }
        [Required]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]

        public string Member_Email { get; set; }

        [StringLength(10)]

        public string Member_Status { get; set; }
        [Required]
        [StringLength(255)]
        public string Member_Address { get; set; }

    }
}
