namespace SimpleCrud.Models.Users;

using System.ComponentModel.DataAnnotations;
using SimpleCrud.Entities;

public class CreateRequest
{
  [Required]
  public string FullName { get; set; }

  [Required]
  [EnumDataType(typeof(Role))]
  public string Role { get; set; }

  [Required]
  [EmailAddress]
  public string Email { get; set; }

  [Required]
  [MinLength(6)]
  public string Password { get; set; }

  [Required]
  [Compare("Password")]
  public string ConfirmPassword { get; set; }
}