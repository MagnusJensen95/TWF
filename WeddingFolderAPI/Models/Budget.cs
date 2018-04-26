using System.Collections.Generic;

namespace WeddingFolderAPI.Models
{
    public class Budget
    {
        public int MaxCost { get; set; }
        public int BudgetId { get; set; }
        public List<BudgetItem> Items{ get; set; }

        public int PlanningFolderId { get; set; }
       
    }
}