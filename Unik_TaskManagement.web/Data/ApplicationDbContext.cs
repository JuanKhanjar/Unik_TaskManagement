﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Unik_TaskManagement.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext ( DbContextOptions<ApplicationDbContext> options )
            : base(options)
        {
        }
    }
}