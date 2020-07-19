using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class FileDbContext : DbContext
    {
        public FileDbContext(DbContextOptions<FileDbContext> options) : base(options)
        {

        }

        public DbSet<Languages> Languages { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Reviews> Reviews { get; set; }


    }