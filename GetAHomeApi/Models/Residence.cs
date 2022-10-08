﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetAHomeApi.Models;

public class Residence
{
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "decimal(16,2)")]
    public decimal Price { get; set; }

    [Required]
    public string? Description { get; set; }

    [Required]
    public string? Summary { get; set; }

    [Required]
    [Display(Name = "Number of Rooms")]
    public int NumberOfRooms { get; set; }

    [Required]
    [Display(Name = "Building Area")]
    public double? BuildingArea { get; set; }

    [Required]
    [Display(Name = "Bee Area")]
    public double? BeeArea { get; set; }

    [Required]
    [Display(Name = "Plot Area")]
    public double? PlotArea { get; set; }

    [Required]
    [Display(Name = "Construction Year")]
    public int ConstructionYear { get; set; }

    [Required]
    [Display(Name = "Number of Views")]
    public int NumberOfViews { get; set; } = 0;

    [Required]
    [Display(Name = "Map Url")]
    public string? MapUrl { get; set; }

    [Required]
    [Display(Name = "Publishing Date")]
    public DateTime? PublishingDate { get; set; }

    [Display(Name = "Viewing Date")]
    public DateTime? ViewingDate { get; set; }



    // Kopplingar
    public int AddressId { get; set; }
    public Address? Address { get; set; } // 1 to 1

    public int ResidenceTypeId { get; set; }
    public ResidenceType? ResidenceType { get; set; } // 1 to many

    public int TenureId { get; set; }
    public Tenure? Tenure { get; set; } // 1 to many

    public int SaleStatusId { get; set; }
    public SaleStatus? SaleStatus { get; set; } // 1 to many

    [Required]
    public string? EstateAgentId { get; set; }
    public AppUser? EstateAgent { get; set; } // 1 to many

    public ICollection<ExpressionOfInterest> ExpressionOfInterests { get; set; } = new List<ExpressionOfInterest>(); // Many to many
}
