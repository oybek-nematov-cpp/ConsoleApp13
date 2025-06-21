using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Fan = "Dasturlash";
            teacher.Name = "Nodirxon";
            teacher.Age = 23;

            Student student = new Student();
            student.Name = "Oybek";
            student.Age = 21;
            student.Id = 13;
            student.nomer = 934240411;

            Console.WriteLine($"Ismi: {teacher.Name}");
            Console.WriteLine($"Yoshi: {teacher.Age}");
            Console.WriteLine($"Fani: {teacher.Fan}");
            Console.WriteLine("==============");
            Console.WriteLine(
            $"Talaba: {student.Name}\nYoshi: {student.Age}\nFan: {student.Id}\nNomeri: {student.nomer}");
        }
    }
}
