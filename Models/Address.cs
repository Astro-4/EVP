using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVP.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "Town/City")]
        public string Town { get; set; }

        [Required]
        [Display(Name = "Plot Number")]
        public int Plot_no { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "Street Name")]
        public string Street { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Post Code")]
        public string Post_code { get; set; }

        public ICollection<Venue> Venues{ get; set; }
    }
}
