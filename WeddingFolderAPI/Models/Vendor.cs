using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class Vendor
    {

        public string Name { get; set; }
        public string Category { get; set; }
        public string Address { get; set; }
        public int VendorId { get; set; }
        public int Price { get; set; }


        public int PlanningFolderId { get; set; }
      

    }
}
