using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using newNest.Models;

namespace newNest.Contexts;
public class NestDbContext : IdentityDbContext<AppUser>
{
    public NestDbContext(DbContextOptions<NestDbContext> options) : base(options)
    {
    }
}

