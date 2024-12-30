using System.ComponentModel.DataAnnotations;

namespace ASP.Net.Models        
{
    public class MemberShip
    {
        [Key]
        public int MemberShip_Id { get; set; }
        [Required]
        [StringLength(255)]
        public string MemberShip_Name { get; set; }
        [Required]
        [StringLength(255)]

        public string MemberShip_Description { get; set;}
    }
}
