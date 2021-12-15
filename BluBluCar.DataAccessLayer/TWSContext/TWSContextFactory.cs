using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.TWSContext;

namespace TWS.DataAccessLayer
{
    public class TeamworkSystemContextFactory : IDesignTimeDbContextFactory<TWSDBContext>
    {
        public TWSDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TWSDBContext>();
         
            optionsBuilder.UseSqlServer("Server=DESKTOP-U45QJ4E\\SQLEXPRESS; Database=TWS;Trusted_Connection=True;");
            return new TWSDBContext(optionsBuilder.Options);
        }
    }
}
