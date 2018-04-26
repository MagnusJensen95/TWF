using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class Wishlist
    {

        public List<Wish> Wishes { get; set; }
        public int WishlistId { get; set; }

        public int PlanningFolderId { get; set; }


    }
}
