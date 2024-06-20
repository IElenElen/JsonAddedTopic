namespace JsonAddedTopic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Json");

            /* 1. Napisz program, który wczytuje plik JSON zawierający informacje o kilku osobach (imię, nazwisko, wiek)
            i wyświetla te informacje na konsoli */
            string filePath = @"C:\Users\Ilka\Desktop\.net\people.json";
            string json = File.ReadAllText(filePath);
            Console.WriteLine(json);

            /* 2. Stwórz klasę Person z polami FirstName, LastName, Age.
            Następnie utwórz obiekt tej klasy, wypełnij go danymi i zapisz jako JSON do pliku */
            Person person = new Person("Mona", "Dana", 20);
            person.SaveToFileAsJson(filePath);
            Console.WriteLine("Person saved to file as JSON.");
        }
    }
}
