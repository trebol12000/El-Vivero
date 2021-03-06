﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vivero.Models;

namespace Vivero.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contacto> Contacto {get; set;}
        public DbSet<Planta> Planta { get; set; }
        public DbSet<TipoPlanta> TipoPlanta { get; set; }
    }
}
