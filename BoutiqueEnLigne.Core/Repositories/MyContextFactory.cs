using BoutiqueEnLigne.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Repositories
{
    internal class MyContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<MyContext>();

            string bdd = @"server=(LocalDb)\MSSQLLocalDB; database=Boutique_En_Ligne;integrated security=True;MultipleActiveResultSets=True;";

            options.UseSqlServer(bdd);

            return new MyContext(options.Options);
        }
    }
}
