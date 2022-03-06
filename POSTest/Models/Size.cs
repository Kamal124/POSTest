using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POSTest.Models
{
    public class Size
    {
        [Key]
        [DisplayName("Size Number")]
        public int size_id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [DisplayName("Size name")]
        public string size_name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0")]
        [DisplayName("Size Price")]
        public int size_price { get; set; }
        public int Products { get; set; }
        //public virtual Products Products_id { get; set; }
    }
}
