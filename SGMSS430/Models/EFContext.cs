using System;
using System.Data.Entity;
using System.Linq;

namespace SGMSS430.Models
{
    public class EFContext : DbContext
    {
        
        public EFContext() : base("name=EFContext.cs")
        {

        }


        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
       
    }

    
}