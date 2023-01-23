using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudFiapTeste.Models;

namespace CrudFiapTeste.Data
{
    public class CrudFiapTesteContext : DbContext
    {
        public CrudFiapTesteContext (DbContextOptions<CrudFiapTesteContext> options)
            : base(options)
        {
        }

        public DbSet<CrudFiapTeste.Models.UserPromotionRegister> UserPromotionRegister { get; set; }
    }
}
