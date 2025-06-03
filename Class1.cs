using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker
{
    internal class Class1
    {
        public static void Main()
        {

        }
        public static bool ConnectToDB()
        {
            var connectionString = "mongodb+srv://sg_admin_account:Aa48975231@footballpl.wrnyt.mongodb.net/?retryWrites=true&w=majority&appName=FootballPl";
            //var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
            if (connectionString == null)
            {
                Console.WriteLine("You must set your 'MONGODB_URI' environment variable. To learn how to set it, see https://www.mongodb.com/docs/drivers/csharp/current/quick-start/#set-your-connection-string");
                return false;
            }

            var client = new MongoClient(connectionString);
            var collection = client.GetDatabase("BugTracker").GetCollection<BsonDocument>("Bugs");
            return true;

        }
    }
}
