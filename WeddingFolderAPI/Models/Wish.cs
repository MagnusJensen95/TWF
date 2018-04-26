using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class Wish
    {

        public string WishTitle { get; set; }
        public int Price { get; set; }
        public int MustHaveFactor { get; set; }
        public int WishId { get; set; }
    }
}
