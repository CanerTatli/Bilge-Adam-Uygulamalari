using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class Westwind:DbContext
    {
        public Westwind()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-S3GJTPT\\SQLEXPRESS;Database=Westwind;Trusted_Connection=True;";





        }

        
        DbSet<AppUser> AppUsers { get; set; }


            DbSet<Category> Categories { get; set; }

            DbSet<Product> Products { get; set; }
                   




    }
}
