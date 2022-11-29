using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseFirst.Entities
{
    public class TaskEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string? Title { get; set; }
        [Column("ball")]
        public int Ball { get; set; }
        [Column("description")]
        public string? Description { get; set; }
    }
}
