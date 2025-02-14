namespace AquariumForum.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now;

        //foreign key
        int DiscussionId { get; set; }

        //navigation property
        public Discussion? Discussion { get; set; }
    }
}
