using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GetAHomeApi.Models;

public class AppUser : IdentityUser
{
    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }
}
