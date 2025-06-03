using BugTracker.models;
using Microsoft.Data.Sqlite;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker
{
    internal class DBOperations
    {
        public static void Main()
        {

        }

        public static bool ConnectToDB()
        {
            //replace with db location from settings file
            var connection = new SqliteConnection("Data Source=BugTracker.db");
            try
            {
                connection.Open();
                bool result = CreateDefaultTables(connection);
                if(!result)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static bool CreateDefaultTables(SqliteConnection conn)
        {
            var sql = @"CREATE TABLE IF NOT EXISTS bugs(
                id INTEGER PRIMARY KEY,
                description TEXT NOT NULL,
                version TEXT NOT NULL,
                status TEXT NOT NULL,
                priority TEXT NOT NULL,
                detectedBy TEXT NOT NULL,
                dateDetected TEXT NOT NULL,
                IssueNotes TEXT NOT NULL,
                FixNotes TEXT NOT NULL
            )";

            var sql2 = @"CREATE TABLE IF NOT EXISTS enhancements(
                id INTEGER PRIMARY KEY,
                description TEXT NOT NULL,
                version TEXT NOT NULL,
                status TEXT NOT NULL,
                priority TEXT NOT NULL,
                detectedBy TEXT NOT NULL,
                dateDetected TEXT NOT NULL,
                notes TEXT NOT NULL
            )";

            var sql3 = @"CREATE TABLE IF NOT EXISTS products(
                id INTEGER PRIMARY KEY,
                description TEXT NOT NULL,
                notes TEXT NOT NULL,
                technology TEXT NOT NULL
            )";

            var sql4 = @"CREATE TABLE IF NOT EXISTS versions(
                id INTEGER PRIMARY KEY,
                productId INTEGER NOT NULL,
                version TEXT NOT NULL,
                FOREIGN KEY (productId)
                REFERENCES products (id) 
            )";

            //var connection = new SqliteConnection("Data Source=BugTracker.db");
            try
            {
                //connection.Open();
                SqliteCommand command = new SqliteCommand(sql, conn);
                SqliteCommand command2 = new SqliteCommand(sql2, conn);
                SqliteCommand command3 = new SqliteCommand(sql3, conn);
                SqliteCommand command4 = new SqliteCommand(sql4, conn);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }

        }

        public static List<BugModelSQL> getBugItems() { 
            List<BugModelSQL> values = new List<BugModelSQL>();
            var sql = @"SELECT b.id, description, a.version, status, priority, detectedBy, dateDetected, IssueNotes, FixNotes FROM bugs as b left join versions as a on b.id = a.productId";
            try
            {
                using var connection = new SqliteConnection("Data Source=BugTracker.db");
                connection.Open();

                using var command = new SqliteCommand(sql, connection);

                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var description = reader.GetString(1);
                        var version = reader.GetString(2);
                        var status = reader.GetString(3);
                        var priority = reader.GetString(4);
                        var detectedBy = reader.GetString(5);
                        var dateDetected = reader.GetString(6);
                        var notesIssue = reader.GetString(7);
                        var notesFixes = reader.GetString(8);
                        BugModelSQL bm = new BugModelSQL(id, description, version, status, priority, detectedBy, DateTime.Parse(dateDetected), notesIssue, notesFixes);
                        values.Add(bm);
                    }
                }
                else
                {
                    Console.WriteLine("No bugs found.");
                }

            }
            catch (SqliteException ex)
            {
                Console.WriteLine(ex.Message);
                return values;
            }

            return values; 
        }
        public static bool ConnectToMongoDB()
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

        public static List<string> getBugItemsMongo ()
        {
            List<string> bugItems = new List<string> ();
            var connectionString = "mongodb+srv://sg_admin_account:Aa48975231@footballpl.wrnyt.mongodb.net/?authSource=admin&appName=FootballPl";
            //var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
            if (connectionString == null)
            {
                Console.WriteLine("You must set your 'MONGODB_URI' environment variable. To learn how to set it, see https://www.mongodb.com/docs/drivers/csharp/current/quick-start/#set-your-connection-string");
            }
            var settings = MongoClientSettings.FromConnectionString(connectionString);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            try
            {
                List<string> databases = client.ListDatabaseNames().ToList();
                foreach (string database in databases)
                {
                    System.Diagnostics.Debug.WriteLine(database);
                }
                //var _collection = client.GetDatabase("BugTracker").GetCollection<BsonDocument>("Bugs");
                //System.Diagnostics.Debug.WriteLine("Got collection");
                ////var filter = Builders<BsonDocument>.Filter.Eq(r=>r.Description, "First Test Bug");
                //var items = _collection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
                //foreach (BsonDocument itm in items)
                //{
                //    System.Diagnostics.Debug.WriteLine(itm.GetElement("Description"));
                //}
            } catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            
            
            return bugItems;
        }

        
    }
}
