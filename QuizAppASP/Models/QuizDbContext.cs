using QuizAppASP.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuizAppASP.Models
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext() : base("name=quizEntities")        
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<QuizMaster> QuizMaster { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<QuizAnswer> QuizAnswers { get; set; }
        public DbSet<QuizScore> QuizScore { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new QuizMasterConfiguration());
            modelBuilder.Configurations.Add(new QuizScoreConfiguration());
        }
    }
}