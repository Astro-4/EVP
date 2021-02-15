using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVP.Models
{
    public class Booking
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Booking_date { get; set; }

        [Required]
        [Display(Name = "Booking Fee")]
        public double Booking_fee { get; set; }

        public int Eventid { get; set; }
        public Event Event { get; set; }
        public int Userid { get; set; }
        public User User { get; set; }
    }
}
