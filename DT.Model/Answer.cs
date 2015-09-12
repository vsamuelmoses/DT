using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DT.Model
{
    public class Answer
    {
        public int Id { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        
        [Required]
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
