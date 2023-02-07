namespace STUDIReplays2023.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual List<Replay>? ReplaysLies { get; set; }
    }
}
