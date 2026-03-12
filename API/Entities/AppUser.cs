using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.SignalR;

namespace API.Entities;

public class AppUser
{
    public String Id { get; set; } = Guid.NewGuid().ToString();

    public required String DisplayName { get; set; }

    public required String Email { get; set; }

    public string? ImageUrl { get; set; }

    public required byte[] PasswordHash { get; set;}
    
    public required byte[] PasswordSalt { get; set; }

    // Nav property
    public Member Member { get; set; } = null!;
}
