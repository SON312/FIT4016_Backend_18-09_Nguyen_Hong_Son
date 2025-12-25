using System.ComponentModel.DataAnnotations;

namespace CategoryAPI;
public class Category
{
    public int Id { get; set; }
    // TODO: Thêm [Required] và [StringLength(100, MinimumLength = 3)]
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }
    public bool IsActive { get; set; }
}