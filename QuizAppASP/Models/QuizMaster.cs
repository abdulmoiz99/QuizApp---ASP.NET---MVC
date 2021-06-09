using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizAppASP.Models
{
    public class QuizMaster
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Account Account { get; set; }
        [ForeignKey("Account")]
        public int CreatedBy { get; set; }
    }
}