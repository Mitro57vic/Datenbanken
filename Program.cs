using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace Mongodb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "UserNoteManagementDB;";
            string userProfilesCollectionName = "userProfiles";
            string notesCollectionName = "notes";

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            var userProfilesCollection = database.GetCollection<BsonDocument>(userProfilesCollectionName);
            var notesCollection = database.GetCollection<BsonDocument>(notesCollectionName);

            Console.WriteLine("Willkommen zur Benutzer- und Notizverwaltung!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Bitte wählen Sie eine Aktion aus:");
                Console.WriteLine("1. Neues Benutzerprofil hinzufügen");
                Console.WriteLine("2. Neue Notiz hinzufügen");
                Console.WriteLine("3. Beenden");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddNewUserProfile(userProfilesCollection);
                        break;
                    case "2":
                        AddNewNote(userProfilesCollection, notesCollection);
                        break;
                    case "3":
                        Console.WriteLine("Programm wird beendet.");
                        return;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine der verfügbaren Optionen.");
                        break;
                }
            }
        }

        static void AddNewUserProfile(IMongoCollection<BsonDocument> userProfilesCollection)
        {
            Console.WriteLine();
            Console.WriteLine("Neues Benutzerprofil hinzufügen:");

            Console.Write("Benutzername: ");
            string username = Console.ReadLine();

            Console.Write("E-Mail: ");
            string email = Console.ReadLine();

            Console.Write("Passwort: ");
            string password = Console.ReadLine();

            var newUser = new BsonDocument
            {
                { "username", username },
                { "email", email },
                { "password", password },
                { "created_at", DateTime.UtcNow },
                { "updated_at", DateTime.UtcNow }
            };

            userProfilesCollection.InsertOne(newUser);
            Console.WriteLine("Neuer Benutzer hinzugefügt!");
        }

        static void AddNewNote(IMongoCollection<BsonDocument> userProfilesCollection, IMongoCollection<BsonDocument> notesCollection)
        {
            Console.WriteLine();
            Console.WriteLine("Neue Notiz hinzufügen:");

            Console.Write("Benutzername des Notiz-Erstellers: ");
            string username = Console.ReadLine();

            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var user = userProfilesCollection.Find(filter).FirstOrDefault();

            if (user == null)
            {
                Console.WriteLine($"Benutzer '{username}' nicht gefunden.");
                return;
            }

            Console.Write("Titel der Notiz: ");
            string title = Console.ReadLine();

            Console.Write("Inhalt der Notiz: ");
            string content = Console.ReadLine();

            var newNote = new BsonDocument
            {
                { "user_id", user["_id"] },
                { "title", title },
                { "content", content },
                { "created_at", DateTime.UtcNow },
                { "updated_at", DateTime.UtcNow }
            };

            notesCollection.InsertOne(newNote);
            Console.WriteLine("Neue Notiz hinzugefügt!");
        }
    }
}
