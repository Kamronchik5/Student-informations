internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();
        Console.WriteLine("Please enter your name :");
        student.Name = Console.ReadLine();
        Console.WriteLine("Then enter your ID :");
        student.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your informations :");
        Console.WriteLine(student.Name + "  " + student.Id);
}
}
 class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}