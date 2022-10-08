using System.ComponentModel.DataAnnotations;

namespace GetAHomeApi.Models;

public class Image
{
    public int Id { get; set; }

    [Required]
    public string? Url { get; set; }

    public bool IsDisplayImage { get; set; } = false;


    // Koppling
    public int ResidenceId { get; set; }
    public Residence? Residence { get; set; }
}
