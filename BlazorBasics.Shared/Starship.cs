using System.ComponentModel.DataAnnotations;

namespace BlazorBasics.Shared;

public class Starship
{
    [Required]
    [StringLength(16, ErrorMessage = "The identifier is too long (16 characters max).")]
    public string? Identifier { get; set; }

    public string? Description { get; set; }

    [Required]
    public string? Classification { get; set; }

    [Range(1, 100000, ErrorMessage = "The accommodation is invalid (1 to 100000).")]
    public int MaximumAccommodation { get; set; }

    [Required]
    [Range(typeof(bool), "true", "true", 
        ErrorMessage = "This form disallows unapproved ships.")]
    public bool IsValidatedDesign { get; set; }

    [Required]
    public DateTime ProductionDate { get; set; }
}