using System;
using System.Collections.Generic;

namespace AuthenticationService.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Picture { get; set; }

    public string Role { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? LineUserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
