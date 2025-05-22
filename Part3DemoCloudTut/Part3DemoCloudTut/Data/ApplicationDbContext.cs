using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Part3DemoCloudTut.Models;

namespace Part3DemoCloudTut.Data
{
    
    public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<EventType> EventTypes { get; set; }
            public DbSet<Venue> Venues { get; set; }
        }
    }

