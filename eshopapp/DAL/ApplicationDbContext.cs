using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace eshopapp.DAL
{
    public class ApplicationDbContext : System.Data.Entity.DbContext
    {
        System.Data.Entity.DbSet <Models.User> Users { get; set; }
    }
}