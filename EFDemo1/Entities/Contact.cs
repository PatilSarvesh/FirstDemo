using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1.Entities
{
    public class Contact
    {
       // [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContactId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "VARCHAR")]
        public string Location { get; set; }
        [MaxLength(10)]

        public string Gender { get; set; }
        [NotMapped]
        public string SceretCode { get; set; }


        //entityframeworktutorials.com
    }
}
