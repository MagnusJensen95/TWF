namespace WeddingFolderAPI.Models
{
    public class ToDoItem
    {

        public string Task { get; set; }
        public int Priority { get; set; }
        public int GuestId{ get; set; }
        public int ToDoItemId { get; set; }
    }
}