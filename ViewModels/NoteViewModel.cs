using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace net6_note_system.ViewModels
{
    public class NoteViewModel
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("標題")]
        public string Title { get; set; }

        [Required]
        [DisplayName("內容")]
        public string Content { get; set; }
    }
}
