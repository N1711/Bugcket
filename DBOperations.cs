using BugTracker.models;
//using Microsoft.Data.Sqlite;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Data.SQLite;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Security.Cryptography.X509Certificates;

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
                productId INTEGER NOT NULL,
                versionId INTEGER NOT NULL,
                description TEXT NOT NULL,
                status TEXT NOT NULL,
                priority TEXT NOT NULL,
                detectedBy TEXT NOT NULL,
                dateDetected TEXT NOT NULL,
                IssueNotes TEXT NOT NULL,
                FixNotes TEXT NOT NULL,
                FOREIGN KEY (productId)
                REFERENCES products (id),
                FOREIGN KEY (versionId)
                REFERENCES versions (id)
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

        public static long InsertBugItem(string description, int product, int version, string status, string priority, string detectedBy, string dateDetected, string notesIssue, string notesFix)
        {
            var sql = "INSERT INTO bugs (description, status, priority, detectedBy, dateDetected, IssueNotes, FixNotes, productId, versionId) VALUES (@description, @status, @priority, @detectedBy, @dateDetected, @notesIssue, @notesFix, @productId, @versionId)";
            if(description.Length == 0 || status.Length == 0 || priority.Length == 0 || detectedBy.Length == 0) {
                return 0;
            }
            try
            {
                var connection = new SQLiteConnection("Data Source=BugTracker.db");
                connection.Open();
                var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@detectedBy", detectedBy);
                command.Parameters.AddWithValue("@dateDetected", dateDetected);
                command.Parameters.AddWithValue("@notesIssue", notesIssue);
                command.Parameters.AddWithValue("@notesFix", notesFix);
                command.Parameters.AddWithValue("@productId", product);
                command.Parameters.AddWithValue("@versionId", version);
                var rowInserted = command.ExecuteNonQuery();
                if(rowInserted > 0)
                {
                    return connection.LastInsertRowId;
                } else
                {
                    return 0;
                }
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
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

        public static bool UpdateBugItem(int id, string description, string status, string priority, string notesIssue, string notesFix)
        {
            var sql = "Update bugs SET description = @description, status = @status, priority = @priority, IssueNotes = @notesIssue, FixNotes = @notesFix WHERE id = @id";
            if (description.Length == 0 || status.Length == 0 || priority.Length == 0)
            {
                return false;
            }
            try
            {
                var connection = new SQLiteConnection("Data Source=BugTracker.db");
                connection.Open();
                var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@notesIssue", notesIssue);
                command.Parameters.AddWithValue("@notesFix", notesFix);
                command.Parameters.AddWithValue("@id", id);
                var rowInserted = command.ExecuteNonQuery();
                return rowInserted > 0;
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static long InsertProductItem(string description, string notes, string technology)
        {
            var sql = "INSERT INTO products (description, notes, technology) VALUES (@description, @notes, @technology)";
            if (description.Length == 0 || notes.Length == 0 || technology.Length == 0)
            {
                return 0;
            }
            try
            {
                var connection = new SQLiteConnection("Data Source=BugTracker.db");
                connection.Open();
                var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@notes", notes);
                command.Parameters.AddWithValue("@technology", technology);
                var rowInserted = command.ExecuteNonQuery();
                if (rowInserted > 0)
                {
                    return connection.LastInsertRowId;
                }
                else
                {
                    return 0;
                }
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }
        }
        public static bool DeleteProductItem(int id)
        {
            string sql = "Delete from products where id = @id";
            var connection = new SQLiteConnection("Data Source=BugTracker.db");
            connection.Open();
            using var command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            var rowDeleted = command.ExecuteNonQuery();
            return rowDeleted > 0;
        }

        public static bool UpdateProductItem(int id, string description, string notes, string technology)
        {
            var sql = "Update products SET description = @description, notes = @notes, technology = @technology WHERE id = @id";
            if (description.Length == 0 || notes.Length == 0 || technology.Length == 0)
            {
                return false;
            }
            try
            {
                var connection = new SQLiteConnection("Data Source=BugTracker.db");
                connection.Open();
                var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@notes", notes);
                command.Parameters.AddWithValue("@technology", technology);
                command.Parameters.AddWithValue("@id", id);
                var rowInserted = command.ExecuteNonQuery();
                return rowInserted > 0;
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static string GetProductItemVersion(int id)
        {
            string versions = "";
            string sql = "Select * from versions where productId = @id order by version desc LIMIT 1";
            var connection = new SQLiteConnection("Data Source=BugTracker.db");
            try
            {
                connection.Open();
                using var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                using SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    versions = reader.GetString(2);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message}");
            }

            return versions;
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
            var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
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
                Debug.WriteLine(e.Message);
            }
            
            
            return bugItems;
        }

        public static List<PriorityModel> GetDropDown(string sql, int key)
        {
            List<PriorityModel> versions = new List<PriorityModel>();
            var connection = new SQLiteConnection("Data Source=BugTracker.db");
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                //command.Parameters.AddWithValue("@description", description);
                using SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(key);
                    versions.Add(new PriorityModel(id, name));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message}");
            }
            
            return versions;
        }


    }
}
