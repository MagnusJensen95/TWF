using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class SeatingPlan
    {

        public int GuestListId { get; set; }
        public int CoupleId { get; set; }
        public int SeatingPlanId { get; set; }

        public int PlanningFolderId { get; set; }
    

    }
}
