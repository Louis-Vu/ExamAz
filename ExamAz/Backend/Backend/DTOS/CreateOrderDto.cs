using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOS
{
    public class CreateOrderDto
    {
       
        [Required]
        [StringLength(16, MinimumLength = 3)]
        public required string ItemName { get; set; }
        [Required]
        public required int ItemQty { get; set; }
    
        [Required(ErrorMessage = "Please enter Delivery")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public required DateTime OrderDelivery { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 3)]
        public required string OrderAddress { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 3)]
        public required string PhoneNumber { get; set; }
    }
}
