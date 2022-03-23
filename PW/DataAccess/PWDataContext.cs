using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PW.Modules.Course.Entities;
using PW.Modules.User.Entities;

namespace PW.DataAccess
{
    public class PWDataContext : DbContext
    {
        public PWDataContext(DbContextOptions options) : base(options)
        {
        }
        #region "COMMON >> GRADE"
        public DbSet<Grade> Grade { get; set; }
        #endregion
        #region "COURSE"
        public DbSet<CourseCategory> CourseCategory { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseAttachments> CourseAttachment { get; set; }
        #endregion

        #region "USER"
        public DbSet<User> User { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Student> Student { get; set; }
        #endregion
    }
}
