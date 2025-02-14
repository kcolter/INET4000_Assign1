namespace AquariumForum.Models
{
    public class Discussion
    {
        public int DiscussionId { get; set; } //primary key
        public string Title { get; set; } = string.Empty;
        public string Content {  get; set; } = string.Empty;
        public string ImageFilename { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now; 

        //Navigation property
        public List<Comment>? Comments { get; set; }

    }
}
