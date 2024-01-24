using System.ComponentModel.DataAnnotations;

namespace Backend.DTOS;

public class EditOrderDto
{
    [Required]
    
    public required DateTime OrderDelivery { get; set; }
    [Required]
    [StringLength(16, MinimumLength = 3)]
    public required string OrderAddress { get; set; }
}
