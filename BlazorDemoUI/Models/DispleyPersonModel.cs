using System.ComponentModel.DataAnnotations;

namespace BlazorDemoUI.Models;

public class DispleyPersonModel
{
    [Required]
    [StringLength(25, ErrorMessage ="First Name is too long!")]
    [MinLength(5,ErrorMessage ="First Name is too short")]
    public string? FirstName { get; set; }
    [StringLength(25, ErrorMessage = "Last Name is too long!")]
    [MinLength(5, ErrorMessage = "Last Name is too short")]
    public string? LastName { get; set; }

    [Required]
    [EmailAddress]
    public string? EmailAddress { get; set; }
}
