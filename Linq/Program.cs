namespace Linq;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = GetPersons();

        

        //foreach (Person person in persons)
        //{
        //    Console.WriteLine(person);
        

        var arrP = persons.ToArray();

        var intArr = new  int[] { 1, 2, 3, 4 };

        intArr.ForEach(Console.WriteLine);

        arrP.ForEach(Console.WriteLine);

        //persons.ForEach(p => Console.WriteLine(p));
        //persons.ForEach(Console.WriteLine);
        //persons.ForEach(p => Print(p));
        //persons.ForEach(Print);


        //var personOver30 = persons.CustomWhere(p => p.Age > 30)
        //                          .Where(p => p.Name.Length > 3)
        //                          .Select(p => p.Name);

        var personOver30 = persons.Where(p => Over30(p))
                                  // .Where(p => p.Name.Length > 3)
                                  .Select(p => p.Age)
                                  .Sum();

        var newObj = persons.Where(p => Over30(p))
                                  .Select(p => new NewObj
                                  {
                                      Name = p.Name,
                                      NamesLength = p.Name.Length,
                                      Time = DateTime.Now
                                  });
                              

        var firstNisse = persons.FirstOrDefault(Over30);
    }

    private static void Print(Person p)
    {
        Console.WriteLine(p);
    }

    private static bool Over30(Person p)
    {
        return p.Age > 30;
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
