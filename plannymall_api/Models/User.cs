using System;
using System.Collections.Generic;

namespace plannymall_api.Models;

public partial class User
{
    public int Id { get; set; }

    public string Uuid { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int PhoneNumberId { get; set; }

    public byte[] PasswordHash { get; set; } = null!;

    public byte[] PasswordSale { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool IsDeleted { get; set; }

    public bool PasswordReset { get; set; }

    public bool IsActive { get; set; }

    public bool IsBlocked { get; set; }

    public bool IsReported { get; set; }
}
