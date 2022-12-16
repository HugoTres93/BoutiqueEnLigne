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

            options.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB; database=Boutique_En_Ligne;integrated security=True;MultipleActiveResultSets=True;");

            return new MyContext(options.Options);
        }
    }
}
