using BugTracker.models;
//using Microsoft.Data.Sqlite;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

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
            var connection = new SQLiteConnection("Data Source=BugTracker.db");
            try
            {
                connection.Open();
                //bool result = CreateDefaultTables(connection);
                //if(!result)
                //{
                //    return false;
                //}
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static bool CreateDefaultTables(SQLiteConnection conn)
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

            var sql5 = @"CREATE TABLE IF NOT EXISTS users(
                id INTEGER PRIMARY KEY,
                name TEXT NOT NULL,
                accessLevel INTEGER NOT NULL
            )";

            //var connection = new SqliteConnection("Data Source=BugTracker.db");
            try
            {
                //connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                SQLiteCommand command2 = new SQLiteCommand(sql2, conn);
                SQLiteCommand command3 = new SQLiteCommand(sql3, conn);
                SQLiteCommand command4 = new SQLiteCommand(sql4, conn);
                SQLiteCommand command5 = new SQLiteCommand(sql5, conn);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                command5.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }

        }

        public static SQLiteDataAdapter getDbItems(string sql) { 
            try
            {
                var connection = new SQLiteConnection("Data Source=BugTracker.db");
                connection.Open();

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, connection);
                return dataAdapter;
                

            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public static bool InsertBugItem(string description, string version, string status, string priority, string detectedBy, string dateDetected, string notesIssue, string notesFix)
        {
            var sql = "INSERT INTO bugs (description, version, status, priority, detectedBy, dateDetected, IssueNotes, FixNotes) VALUES (@description, @version, @status, @priority, @detectedBy, @dateDetected, @notesIssue, @notesFix)";
            if(description.Length == 0 || version.Length == 0 || status.Length == 0 || priority.Length == 0 || detectedBy.Length == 0) {
                return false;
            }
            try
            {
                var connection = new SQLiteConnection("Data Source=BugTracker.db");
                connection.Open();
                var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@version", version);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@detectedBy", detectedBy);
                command.Parameters.AddWithValue("@dateDetected", dateDetected);
                command.Parameters.AddWithValue("@notesIssue", notesIssue);
                command.Parameters.AddWithValue("@notesFix", notesFix);
                var rowInserted = command.ExecuteNonQuery();
                return rowInserted > 0;
            }
            catch (SQLiteException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool DeleteItem(int id)
        {
            string sql = "Delete from bugs where id = @id";
            var connection = new SQLiteConnection("Data Source=BugTracker.db");
            connection.Open();
            using var command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            var rowDeleted = command.ExecuteNonQuery();
            return rowDeleted > 0;
        }

        public static bool UpdateBugItem(int id, string description, string version, string status, string priority, string detectedBy, string dateDetected, string notesIssue, string notesFix)
        {
            var sql = "Update bugs SET description = @description, version = @version, status = @status, priority = @priority, detectedBy = @detected, dateDetected = @dateDetected, IssueNotes = @notesIssue, FixNotes = @notesFix where id = @id";
            if (description.Length == 0 || version.Length == 0 || status.Length == 0 || priority.Length == 0 || detectedBy.Length == 0)
            {
                return false;
            }
            try
            {
                var connection = new SQLiteConnection("Data Source=BugTracker.db");
                connection.Open();
                using var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@version", version);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@detectedBy", detectedBy);
                command.Parameters.AddWithValue("@dateDetected", dateDetected);
                command.Parameters.AddWithValue("@notesIssue", notesIssue);
                command.Parameters.AddWithValue("@notesFix", notesFix);
                command.Parameters.AddWithValue("@id", id);
                var rowInserted = command.ExecuteNonQuery();
                return rowInserted > 0;
            }
            catch (SQLiteException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }


        public static bool ConnectToMongoDB()
        {
            var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
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
