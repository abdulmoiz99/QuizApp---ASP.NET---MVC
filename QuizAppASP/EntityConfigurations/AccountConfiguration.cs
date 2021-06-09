using QuizAppASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace QuizAppASP.EntityConfigurations
{
    public class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration() 
        {
            ToTable("Users");

            HasKey(a => a.Id);

            Property(a => a.FirstName)
            .IsRequired()
            .HasMaxLength(256);

            Property(a => a.LastName)
            .IsRequired()
            .HasMaxLength(256);

            Property(a => a.Password)
            .IsRequired()
            .HasMaxLength(256);

            Property(a => a.Email)
            .IsRequired()
            .HasMaxLength(256);

        }
    }
}