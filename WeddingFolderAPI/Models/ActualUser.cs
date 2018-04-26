using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class ActualUser
    {
        public int Id { get; set; }
        
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }

        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }  // navigation property
    }
}
