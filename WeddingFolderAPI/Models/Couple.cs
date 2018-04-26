using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Models
{
    public class Couple
    {

        public int CoupleId { get; set; }
        public string CoupleName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<PlanningFolder> PlanningFolders { get; set; }
    }
}
