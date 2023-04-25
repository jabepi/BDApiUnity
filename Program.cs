using Microsoft.Data.Sqlite;

// Cambia el valor de "yourDatabaseFile.db" por el nombre de tu archivo de base de datos
string connectionString = $"Data Source=baseDatos.db;";

// Crear y abrir una conexión a la base de datos
using (SqliteConnection connection = new SqliteConnection(connectionString))
{
    connection.Open();

    // Crear un comando para realizar consultas en la base de datos
    string sql = "SELECT * FROM E"; // Cambia "your_table_name" por el nombre de tu tabla
    using (SqliteCommand command = new SqliteCommand(sql, connection))
    {
        // Ejecutar el comando y obtener los resultados en un objeto SqliteDataReader
        using (SqliteDataReader reader = command.ExecuteReader())
        {
            // Leer los resultados fila por fila
            while (reader.Read())
            {
              
            }
        }
    }
    //Instalar los drivers en Unity
    //Clase con los datos y el consumo 
    //Campus
    // Cerrar la conexión
    connection.Close();
}
