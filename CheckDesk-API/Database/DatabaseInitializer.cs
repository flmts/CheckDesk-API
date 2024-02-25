
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace CheckDesk_API.Database;
public class DatabaseInitializer
{
    public static void InitializeDatabase()
    {
        ApplicationData.Current.LocalFolder.CreateFileAsync("sqliteSample.db", CreationCollisionOption.OpenIfExists);
        string sqlFilePath = "C:\\Users\\flori\\Downloads\\projetparc3il.sql";

        // Vérifier si le fichier de base de données SQLite n'existe pas déjà
        if (!File.Exists(databasePath))
        {

            // Établir une connexion à la base de données SQLite
            using (SqliteConnection connection = new SqliteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();

                // Lire le script SQL depuis le fichier
                string sqlScript = File.ReadAllText(sqlFilePath);

                // Diviser le script SQL en instructions individuelles
                string[] sqlStatements = sqlScript.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                // Exécuter chaque instruction SQL
                foreach (string sqlStatement in sqlStatements)
                {
                    using (SqliteCommand command = new SqliteCommand(sqlStatement, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Base de données créée avec succès.");
            }
        }
        else
        {
            Console.WriteLine("La base de données existe déjà.");
        }
    }
}
