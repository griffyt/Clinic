namespace Domain;

public abstract class Person
{
    public static string Id {get;set;}
    public string Name {get;set;}
    public int Age {get;set;}

    public abstract string GetInfo();
    public Person(string _name, int _age)
    {
        Id = Guid.NewGuid().ToString();
        Name = _name;
        Age = _age;  
    }
}
