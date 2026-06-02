using System;
using System.Collections.Generic;
using System.Text;

namespace Linq;

internal class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"Name: {Name} Age: {Age}";
}
