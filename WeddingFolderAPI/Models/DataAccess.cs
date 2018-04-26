
//MONGO CONNECTION STUFF

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using MongoDB.Bson;
//using MongoDB.Driver;
//using MongoDB.Driver.Builders;
//using MongoDB.Driver.Linq;

//namespace WeddingFolderAPI.Models
//{
//    public class DataAccess
//    {
//        MongoClient _client;
//        MongoServer _server;
//        IMongoDatabase _db;

//        public DataAccess()
//        {
//            _client = new MongoClient("mongodb://localhost:27017");

//            //Wut
//            //_server = _client.GetServer();
//            //_server = new MongoServer(MongoServerSettings.FromClientSettings(_client.Settings));
//            _db = _client.GetDatabase("TWF");
//        }

//        public IEnumerable<Couple> GetCouples()
//        {
//            // var collection = _db.GetCollection<Product>("Products");


//            var re = _db.GetCollection<Couple>("Couples").Find(x => true).ToList()
//              ;

//            return re;
//        }


//        public Couple GetCouple(int id)
//        {
           
//            var res = Query<Couple>.EQ(p => p.CoupleId, id);

//            Console.WriteLine("result: " + res);
//            return _db.GetCollection<Couple>("Couples").Find(_ => true).ToList().SingleOrDefault(c => c.CoupleId == id);
//        }

//        public Couple Create(Couple p)
//        {
//            return null;
//            //_db.GetCollection<Couple>("Couples").Save(p);
//            //return p;
//        }

//        public void Update(ObjectId id, Couple p)
//        {
            
//            //p.InternalId = id;
//            //var res = Query<Couple>.EQ(pd => pd.InternalId, id);
//            //var operation = Update<Couple>.Replace(p);
//            //_db.GetCollection<Couple>("Couples").Update(res, operation);
//        }
//        public void Remove(ObjectId id)
//        {
//            //var res = Query<Couple>.EQ(e => e.InternalId, id);
//            //var operation = _db.GetCollection<Couple>("Couples").Remove(res);
//        }
//    }
//}
