using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class Location
    {
        public string Address { get; set; }
        public string LocationName { get; set; }
        public DateTime DateBooked { get; set; }
        public int LocationId { get; set; }

        public int PlanningFolderId { get; set; }
       

    }
}
