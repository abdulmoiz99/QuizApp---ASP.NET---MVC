using QuizAppASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace QuizAppASP.EntityConfigurations
{
    public class QuizMasterConfiguration : EntityTypeConfiguration<QuizMaster>
    {
        public QuizMasterConfiguration()
        {
            ToTable("QuizMaster");

            HasKey(q => q.Id);

            Property(q => q.Title)
            .IsRequired()
            .HasMaxLength(256);

            Property(q => q.Active)
            .IsRequired();

            Property(q => q.DateCreated)
            .IsRequired();

            HasRequired(q => q.Account)
                .WithMany().WillCascadeOnDelete(false);

        }
    }
}