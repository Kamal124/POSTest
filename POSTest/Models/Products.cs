using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSTest.Models
{
    public class Products
    {
        [Key]
        public int Products_id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [DisplayName("Product Name")]
        public string Products_Name { get; set; }
        public int Products_Price { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        [Required(ErrorMessage = "Please choose file to upload.")]
        public string Products_Image { get; set; }
        public int size { get; set; }
        //[DisplayName("Product size count")]
        //public virtual ICollection<Size> Sizes { get; set; }"../../assets/media/image/user/man_avatar3.jpg"
    }
}
