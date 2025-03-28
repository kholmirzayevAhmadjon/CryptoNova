﻿using CryptoNova.Domain.Commons;

namespace CryptoNova.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public long RoleId { get; set; }
    public Role Role { get; set; }
}
