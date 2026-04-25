using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wildasdd_it7024_final_introspect
{
    [Table("scores")]
    public class Scores
    {
        [PrimaryKey]
        [Column("input_date")]
        public DateTime InputDate { get; set; }
        [Column("emotion_score")]
        public int EmotionScore { get; set; }
        [Column("self_score")]
        public int SelfScore { get; set; }
        [Column("thought_score")]
        public int ThoughtScore { get; set; }
        [Column("introspect_score")]
        public int IntrospectScore { get; set; }
    }
}
