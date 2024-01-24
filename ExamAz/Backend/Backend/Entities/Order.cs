using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities;

public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ItemCode { get; set; }
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
