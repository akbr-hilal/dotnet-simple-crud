namespace SimpleCrud.Entities;

using System.Text.Json.Serialization;

public class User
{
  public int Id { get; set; }

  public string FullName { get; set; }

  public string Email { get; set; }

  public Role Role { get; set; }

  [JsonIgnore]
  public string PasswordHash { get; set; }
}