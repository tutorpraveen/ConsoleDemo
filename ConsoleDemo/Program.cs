using ConsoleDemo;

Console.WriteLine("Enter Name:");
string? input = Console.ReadLine();

Console.WriteLine("How many times you want to repeat the name?");
string? times = Console.ReadLine();

for(int i=0; i< Convert.ToInt32(times); i++)
{
    Console.WriteLine("Hello " + input);
}

Student student = new Student();
student.Name = "Scott";
student.Id = 456;
student.Age = 29;

Console.WriteLine(student.Id);
Console.WriteLine(student.Name);
Console.WriteLine(student.Age);

Console.ReadKey();

