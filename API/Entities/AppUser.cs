using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    [Key]
    public int UserId { get; set; }
    public required string UserName { get; set; }
    public required string FullName { get; set; }
    public int Age { get; set; }

}