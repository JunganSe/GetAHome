using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace GetAHomeApi.Models;

public class AppUser : IdentityUser
{
    [Required]
    [Display(Name = "First Name")]
    [RegularExpression(@"^[A-Za-z -]+$")]
    public string? FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    [RegularExpression(@"^[A-Za-z -]+$")]
    public string? LastName { get; set; }



    // Koppling
    public ICollection<ExpressionOfInterest> ExpressionOfInterests { get; set; } = new List<ExpressionOfInterest>(); // Many to many
    public ICollection<Residence> Residences { get; set; } = new List<Residence>(); // 1 to many
}
