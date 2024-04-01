using System;
using Microsoft.AspNetCore.Identity;

namespace newNest.Models;

public class AppUser : IdentityUser
{
    public string FullName { get; set; }
    public bool IsActive { get; set; }
}

