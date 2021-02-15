using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVP.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "Name")]
        public string Event_name { get; set; }

        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Event_date { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "Type")]
        public string Event_type { get; set; }

        [Required]
        [Display(Name = "Fee")]
        public double Fee { get; set; }

        public int Venueid { get; set; }
        public Venue Venue { get; set; }
        public ICollection<Booking> Bookings{ get; set; }
    }
}
