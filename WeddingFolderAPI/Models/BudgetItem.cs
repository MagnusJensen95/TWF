using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class BudgetItem
    {

        public string ItemName { get; set; }
        public int BudgetItemId { get; set; }
        public int Price { get; set; }

        public int BudgetId { get; set; }
        
    }
}
