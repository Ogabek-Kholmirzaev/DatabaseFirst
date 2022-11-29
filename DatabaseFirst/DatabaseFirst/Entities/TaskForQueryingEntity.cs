using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseFirst.Entities
{
    //[Table("tasks")]
    public class TaskForQueryingEntity
    {
        [Column("task_title")]
        public string? Title { get; set; }
        [Column("task_ball")]
        public int Ball { get; set; }
    }
}
