using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizAppASP.Models
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public virtual QuizMaster QuizMaster { get; set; }
        [ForeignKey("QuizMaster")]
        public int QuizMasterId { get; set; }
        [Required]
        public string Description { get; set; }
    }
}