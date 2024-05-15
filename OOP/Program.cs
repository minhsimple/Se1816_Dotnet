// See https://aka.ms/new-console-template for more information

Student st = new Student { Name = "Duc Minh", Age = 5, Email = "ducminhns2004@gmail.com" };

Console.WriteLine(st);

class Student
{
    public Student()
    {
        this.Id = -3;
    }

    public Student(int age, string name, string email)
    {
        this.Age = age;
        this.Email = email;
        this.Name = name;
    }

    private int age;
    private string email;

    public int Id { get; init; } //init-only properties
    public int Age { get { return age; } set { age = value; } }// full properties

    public string Email { get => email; set { email = value; } }

    public string Name { get; set; } = "Nguyen Van A";//Auto Properties

    public override string ToString() //override ToString method
    {
        return $"Student age = {age}, name = {Name}, email = {email}, id = {Id}";
    }
}
