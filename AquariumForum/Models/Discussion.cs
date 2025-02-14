using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquariumForum.Models
{
    public class Discussion
    {
        public int DiscussionId { get; set; } //primary key
        public string Title { get; set; } = string.Empty;
        public string Content {  get; set; } = string.Empty;
        public string ImageFilename { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now;

        //property for file upload, no EF mapping
        [NotMapped]
        [Display(Name = "Image")]
        public IFormFile? ImageFile { get; set; }

        //Navigation property
        public List<Comment>? Comments { get; set; }

    }
}
