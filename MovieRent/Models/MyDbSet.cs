using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieRent.Models
{
    public class MyDbSet : DbSet
    {
        public MyDbSet() : base("MovieRent")
        {

        }
    }
}