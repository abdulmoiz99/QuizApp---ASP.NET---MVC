using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizAppASP.Models
{
    public class QuizScore
    {
        [ForeignKey("Account")]
        public int UserId { get; set; }
        [ForeignKey("QuizMaster")]
        public int QuizId { get; set; }
        public int Score { get; set; }
        public DateTime DateAttempted { get; set; }
        public virtual Account Account { get; set; }
        public virtual QuizMaster QuizMaster { get; set; }
    }
}