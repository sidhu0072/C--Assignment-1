namespace Assignment_1
{
    public class StudentMethods
    {
        public static Student CreateStudent(int id, StudentType type, string firstName, string lastName)
        {

            firstName ??= "Unknown";
            lastName ??= "";
            return new Student
            {
                Id = id,
                Type = type,
                FirstName = firstName,
                LastName = lastName
            };
        }

        public static void OutputStudent(Student student)
        {
            Console.WriteLine($"Id: {student.Id:D3}, Name: {student.FirstName} {student.LastName},  Type: ({student.Type}),");
        }
    }
}