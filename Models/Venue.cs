using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVP.Models
{
    public class Venue
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Capacity")]
        public int Capacity{ get; set; }

        public int Addressid { get; set; }
        public Address Address { get; set; }
        public ICollection<Event> Events{ get; set; }
    }
}
