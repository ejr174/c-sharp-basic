

var persona1 = new Persona("Emmanuel");

persona1.Nombre = "Cristiano";


var message = persona1.Saludar();

Console.WriteLine(message);


class Persona 
{
    public string Nombre { get; set; }
    private int Edad { get; set; }

    public Persona(string nombre) {
        this.Nombre = nombre;
        Edad = 0;
    }

    public string Saludar() {
        return "Hola, " + this.Nombre + "!";
    }
}