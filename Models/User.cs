using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models;

public class User
{
    public int Id {get; set;}
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public string? PasswordSalt { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateCreated { get; set; }
    public string? Location {get; set;}
}