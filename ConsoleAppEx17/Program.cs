using System;
using ConsoleAppEx17.Entities;
using System.Collections.Generic;

namespace ConsoleAppEx17
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> totalStudents = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int qttA = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < qttA; i++)
            {
                int cod = Convert.ToInt32(Console.ReadLine());
                totalStudents.Add(new Student(cod));
            }

            Console.Write("How many students for course B? ");
            int qttB = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < qttB; i++)
            {
                int cod = Convert.ToInt32(Console.ReadLine());
                totalStudents.Add(new Student(cod));
            }

            Console.Write("How many students for course C? ");
            int qttC = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < qttC; i++)
            {
                int cod = Convert.ToInt32(Console.ReadLine());
                totalStudents.Add(new Student(cod));
            }

            Console.WriteLine($"Total students: {totalStudents.Count}");
        }
    }
}
