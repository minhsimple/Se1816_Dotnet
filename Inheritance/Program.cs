// See https://aka.ms/new-console-template for more information
Manager jack = new Manager(1000, "Jack", "Jack@gmail.com");
Console.WriteLine(jack);

class Employee
{
    private int id;
    private string name;

    public Employee()
    {
    }

    public Employee(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
    public string Name { get { return name; } set { name = value; } }
    public int Id { get { return id; } set { id = value; } }
}

class Manager : Employee
{
    private string email;
    public Manager()
    {
    }

    public Manager(int id, string name, string email) : base(id, name)
    {
        this.Email = email;
    }

    public string Email { get { return email; } set { email = value; } }

    public override string ToString()
    {
        return $"id: {Id}, name: {Name}, email: {email}";
    }
}