namespace STUDIReplays2023.Models
{
    public class Replay
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateSortie { get; set; }
        public string Url { get; set; }

        public virtual List<Category>? CategoriesLiees { get; set; }
    }

    //Liaison avec playlists
    //Liaison avec catégories ou matière ?
    //Liason avec les formateurs
}
