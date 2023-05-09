using Mapster;
namespace MapsterExample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Graduate
    {
        public int RollNumber { get; set; }
        public string FullName { get; set; }
    }
    public class MappingClass
    {
        public static void main(String[] args)
        {
            Student Source_student = new Student();
            Source_student.Name = "Revathi";
            Console.WriteLine(Source_student.Name);
            Console.ReadLine();
        }
    }
}