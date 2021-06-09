using QuizAppASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace QuizAppASP.EntityConfigurations
{
    public class QuizScoreConfiguration : EntityTypeConfiguration<QuizScore>
    {
        public QuizScoreConfiguration() 
        {
            HasKey(t => new { t.UserId, t.QuizId });
        }
    }
}