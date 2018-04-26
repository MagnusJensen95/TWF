using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class PlanningFolder
    {
        public string FolderName { get; set; }
        public string Purpose { get; set; }
        public int PlanningFolderId { get; set; }


        public Wishlist WishList{ get; set; }



        public SeatingPlan SeatingPlan{ get; set; }
        public List<Vendor> Vendors { get; set; }
        public ToDoList ToDoList { get; set; }
        public GuestList GuestList { get; set; }
        public Location Location { get; set; }
        public Budget Budget { get; set; }

        //Ref
        public int CoupleId { get; set; }


    }
}
