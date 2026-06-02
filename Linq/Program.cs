namespace Linq;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = GetPersons();

        foreach (Person person in persons)
        {
            Console.WriteLine(person);
        }

        persons.ForEach(p => Console.WriteLine(p));
        persons.ForEach(Console.WriteLine);
        persons.ForEach(p => Print(p));
        persons.ForEach(Print);
    }

    private static void Print(Person p)
    {
        Console.WriteLine(p);
    }


    private static List<Person> GetPersons()
    {
        return[
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("Olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Lisa",   45),
                new("Sophia-Magdalena", 32)
              ];
    }
}
