using System.ComponentModel.DataAnnotations;

namespace GetAHomeApi.Models;

public class Tenure
{
    public int Id { get; set; }

    [Required]
    public string? Description { get; set; }



    // Koppling
    public ICollection<Residence> Residences { get; set; } = new List<Residence>();
}
