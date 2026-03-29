
// Genericos: Podemos utilizar genéricos para crear clases o métodos
// que puedan trabajar con diferentes tipos de datos sin necesidad de duplicar código.

var personajes = new MyList<string>(3);
var numeros = new MyList<int>(3);

personajes.AddElement("Mario");
personajes.AddElement("Luigi");
personajes.AddElement("Peach");
//personajes.AddElement("Bowser"); // No se puede agregar, límite alcanzado

Console.WriteLine(personajes.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void AddElement(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
        else
        {
            Console.WriteLine("No se pueden agregar más elementos, límite alcanzado.");
        }
    }

    public string GetContent()
    {
        string content = "";

        foreach (var element in _list)
        {
            content += element + ", ";
        }

        return content;
    }
}