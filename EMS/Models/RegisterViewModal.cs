using System.ComponentModel.DataAnnotations;

public class RegisterViewModal
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [DataType(DataType.Password)]
    [Compare("Password")]
    public string ConfirmPassword { get; set; } = string.Empty;

    public string? Address { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
}
