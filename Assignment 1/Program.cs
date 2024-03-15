using Assignment_1;

class Program
{
    static void Main()
    {
        var student1 = StudentMethods.CreateStudent(1, StudentType.FullTime, "Milan", "Parihar");
        var student2 = StudentMethods.CreateStudent(2, StudentType.FullTime, "Mukul", "Thakur");
        var student3 = StudentMethods.CreateStudent(3, StudentType.PartTime, "Mohit", "Parihar");

        Console.WriteLine("Assignment One");

        StudentMethods.OutputStudent(student1);
        StudentMethods.OutputStudent(student2);
        StudentMethods.OutputStudent(student3);
    }
}