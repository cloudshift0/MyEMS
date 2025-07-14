using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string FullName { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

}