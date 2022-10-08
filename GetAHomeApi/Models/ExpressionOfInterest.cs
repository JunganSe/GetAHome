using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GetAHomeApi.Models;

public class ExpressionOfInterest
{

    public string? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }

    public int ResidenceId { get; set; }
    public Residence? Residence { get; set; }
}
