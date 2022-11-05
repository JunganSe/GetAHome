using System.ComponentModel.DataAnnotations;

namespace GetAHomeApi.Models;

public class ResidenceType
{
    public int? Id { get; set; }

    [Required]
    public string? Name { get; set; }



    // Koppling
    public ICollection<Residence> Residences { get; set; } = new List<Residence>(); // 1 to many
}
