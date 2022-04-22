#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenLeAn.Models;

    public class NewsContext : DbContext
    {
        public NewsContext (DbContextOptions<NewsContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenLeAn.Models.Category> Category { get; set; }
             public DbSet<NguyenLeAn.Models.Comment> Comment { get; set; }
                     public DbSet<NguyenLeAn.Models.News> News { get; set; }
    }
