
/**
 * CLASES Y OBJETOS
 * CLASE: Es una plantailla o molde que define las caracteterísticas y comportamientos comunes de un conjunto de objetos.
 * OBJETO : Es una intancia de una clase, es decir, un ejemplar concreto que posee las características y comportamientos definidos por la clase.
 * 
 * */

// Formas de crear objetos en C# a partir de una clase:
Persona persona1 = new Persona("Emmanuel");
Persona persona2 = new Persona("Cristiano");
var personaje1 = new PersonajeItachi("Itachi","Sharingan");

persona1.Nombre = "Cristiano";
var messagePersona = persona1.Saludar();
Console.WriteLine(messagePersona);

Console.WriteLine(personaje1.Nombre); // Esta propiedad solo tiene un getter, por lo que no se puede modificar desde fuera de la clase, solo se puede asignar en el constructor.
//personaje1.Nombre = "Sasuke"; // Esto generará un error de compilación, ya que la propiedad Nombre no tiene un setter público.
var messagePersonaje = personaje1.MostrarPoder();
Console.WriteLine(messagePersonaje);
Console.WriteLine(personaje1.Saludar());
Console.WriteLine(personaje1.Saludar("JAJAJAJ! "));


class Persona 
{
    public string Nombre { get; set; }
    private int Edad { get; set; }

    public Persona(string nombre) {
        this.Nombre = nombre;
        Edad = 0;
    }

    public virtual string Saludar() {
        return "Hola, soy tu amigo " + this.Nombre + "!";
    }
}
// Interfaces: Podemos implementar una interfaz para definir un contrato
// que la clase PersonajeItachi debe cumplir. Por ejemplo,
// podríamos crear una interfaz IPoderoso que tenga un método MostrarPoder()
// y luego hacer que la clase PersonajeItachi implemente esa interfaz.

public interface IPoderoso
{
    string MostrarPoder();
}
class PersonajeItachi : Persona, IPoderoso
{
    public string Nombre { get; } // Al no tener SET no pueden modificar el valor de esta propiedad desde fuera de la clase, solo se puede asignar en el constructor.
    public string Poder { get; set; }
    public PersonajeItachi( string nombre, string poder) : base(nombre)
    {
        this.Nombre = "Itachi Uchija";
        this.Poder = poder;
    }
    public string MostrarPoder() {
        return this.Nombre + " tiene el poder de " + this.Poder;
    }

    // Sobreescritura de métodos: Podemos sobrescribir el método Saludar() de la clase base Persona para que el personaje Itachi tenga un saludo personalizado.
    public override string Saludar() {
        return "Hola, soy " + this.Nombre + " y tengo el poder de " + this.Poder;
    }

    // Sobrecarga de métodos: Podemos crear múltiples métodos con el mismo nombre pero con diferentes parámetros para mostrar diferentes formas de saludar.
    public string Saludar(string saludoPersonalizado) {
        return saludoPersonalizado + ", soy " + this.Nombre + " y tengo el poder de " + this.Poder;
    }
}