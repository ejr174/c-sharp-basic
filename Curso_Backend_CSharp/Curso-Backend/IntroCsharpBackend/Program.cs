
// Serializacion y Deserializacion de objetos en C#
// Para serializar un objeto, se puede utilizar la clase JsonSerializer del espacio de nombres System.Text.Json

// La serialización es el proceso de convertir un objeto en una cadena de texto que puede ser almacenada o transmitida.
// La deserialización es el proceso inverso, donde se convierte una cadena de texto en un objeto.

using System.Text.Json;

var emmanuel = new People { Name = "Emmanuel", age = 30 };

// Serializar el objeto a una cadena JSON
string jsonString = JsonSerializer.Serialize(emmanuel);
Console.WriteLine("Objeto serializado a JSON: " + jsonString);

// Deserializar la cadena JSON de vuelta a un objeto
People emmanuelj = JsonSerializer.Deserialize<People>(jsonString);
Console.WriteLine("Objeto deserializado: Nombre = " + emmanuelj.Name + " - Edad = " + emmanuelj.age);



public class People
{
    public string Name { get; set; }
    public int age { get; set; }
}