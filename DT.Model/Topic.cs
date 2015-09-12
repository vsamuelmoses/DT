using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DT.Model
{
    public class Topic
    {
        public Topic()
        {
            Questions = new List<Question>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("Topic")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
