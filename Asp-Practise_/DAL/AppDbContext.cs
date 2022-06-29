 using Asp_Practise_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise_.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Courses> Course { get; set; }
        public DbSet<Events> Event { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<NoticeRight> NoticeRights { get; set; }
        public DbSet<Teachers> Teachers { get; set; }

    }
}
