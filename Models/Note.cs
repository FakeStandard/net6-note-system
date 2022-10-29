using System.ComponentModel.DataAnnotations;

namespace net6_note_system.Models
{
    public class Note
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public int CreateUser { get; set; }

        public DateTime CreateTime { get; set; }

        public int? ModifyUser { get; set; }

        public DateTime? ModifyTime { get; set; }
    }
}
