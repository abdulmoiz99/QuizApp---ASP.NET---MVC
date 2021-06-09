using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizAppASP.Models
{
    public class QuizAnswer
    {
        public int Id { get; set; }
        public virtual QuizQuestion QuizQuestion { get; set; }
        [ForeignKey("QuizQuestion")]
        public int QuizQuestionId { get; set; }
        public bool IsCorrect { get; set; }
        [Required]
        public string Description { get; set; }
    }
}