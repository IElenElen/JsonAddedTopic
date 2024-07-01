using System.Text.Json.Nodes;
using System.Text.Json;

namespace JsonAddedTopic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Json");

            /* Napisz program, który wczytuje plik JSON zawierający informacje o kilku osobach 
               (imię, nazwisko, wiek) i wyświetla te informacje na konsoli */
            string filePath = @"C:\Users\Ilka\Desktop\.net\people.json";
            string json = File.ReadAllText(filePath);
            Console.WriteLine(json);

            /* Stwórz klasę Person z polami FirstName, LastName, Age.
            Następnie utwórz obiekt tej klasy, wypełnij go danymi i zapisz jako JSON do pliku */
            Person person = new Person("Mona", "Dana", 20);
            person.SaveToFileAsJson(filePath);
            Console.WriteLine("Person saved to file as JSON.");

            /* 1. Napisz program, który wczytuje plik JSON zawierający informacje o kilku książkach 
               (tytuł, autor, rok wydania) i wyświetla te informacje na konsoli. */

            /* 2. Stwórz klasę Car z polami Make, Model, Year, Mileage. 
               Utwórz obiekt tej klasy, wypełnij go danymi i zapisz jako JSON do pliku. */

            /* 3. Napisz program, który odczytuje JSON z pliku 
               i deserializuje go do obiektu klasy Movie (z polami Title, Director, ReleaseYear, Genre). 
               Wyświetl dane obiektu na konsoli. */
        }
    }
}
