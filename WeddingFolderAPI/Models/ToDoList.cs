using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class ToDoList 
    {
        public List<ToDoItem> Items { get; set; }
        public int ToDoListId { get; set; }

        public int PlanningFolderId { get; set; }
      

    }
}
