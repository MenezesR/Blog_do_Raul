using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Blog_do_Raul.Models
{
    public class Blogcontext:DbContext
    {
        public DbSet<Post> Post { get; set; }
        public Blogcontext():base("DefaultConnection")
        {

        }

    }
}