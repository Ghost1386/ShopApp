using System.ComponentModel.DataAnnotations;

namespace ShopApp.ViewModels;

public class ProductViewModel
{
    [Required]
    [MinLength(5)]
    [StringLength(30)]
    public string Title { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    public string Price { get; set; }
    
    [Required]
    [MinLength(6)]
    [StringLength(18)]
    public string Amount { get; set; }
}