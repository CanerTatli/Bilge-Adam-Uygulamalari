using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    internal class Westwind:DbContext
    {
        public Westwind()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-S3GJTPT\\SQLEXPRESS;Database=Westwind;Trusted_Connection=True;";





        }

    }
}
