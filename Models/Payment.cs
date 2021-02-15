using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVP.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Payment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Payment_date { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public double Payment_amount { get; set; }

        public int Bookingid { get; set; }

        public Booking Booking { get; set; }
    }
}
