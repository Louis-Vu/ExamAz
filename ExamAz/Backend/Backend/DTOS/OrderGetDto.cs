using System.ComponentModel.DataAnnotations;

namespace Backend.DTOS
{
    public class OrderGetDto
    {
        [Required]
        public required int Id { get; set; }    
        [Required]
     
        public required string ItemName { get; set; }
        [Required]
        public required int ItemQty { get; set; }
        [Required]
  
        public required DateTime OrderDelivery { get; set; }
        [Required]

        public required string OrderAddress { get; set; }
        [Required]

        public required string PhoneNumber { get; set; }
    }
}
