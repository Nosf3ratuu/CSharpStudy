var person = new Person //This is Object Initialisation, not all properties need to be set
{
    Name = "John",
    YearOfBirth = 1981
};

Console.ReadKey();

class Person
{
    public string Name {get; init;} //use of init sets a value only during object construction
    public int YearOfBirth {get; set;}

    // public Person(string name, int yearOfBirth)
    // {
    //     Name = name;
    //     YearOfBirth = yearOfBirth;
    // }
}