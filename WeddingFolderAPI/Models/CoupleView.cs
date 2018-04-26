using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class CoupleView
    {
        public string ObjectId { get; set; }
        public int CoupleId { get; set; }
        public string CoupleName { get; set; }
        public ICollection<PlanningFolder> Folders { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
