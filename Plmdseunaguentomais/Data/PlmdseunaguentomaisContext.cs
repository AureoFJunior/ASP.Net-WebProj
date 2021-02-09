using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plmdseunaguentomais.Models;

namespace Plmdseunaguentomais.Data
{
    public class PlmdseunaguentomaisContext : DbContext
    {
        public PlmdseunaguentomaisContext (DbContextOptions<PlmdseunaguentomaisContext> options)
            : base(options)
        {
        }

        public DbSet<Plmdseunaguentomais.Models.Department> Department { get; set; }
    }
}
