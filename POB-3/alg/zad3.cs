using System;
using System.Diagnostics.CodeAnalysis;

namespace fa
{
    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            private int[] Oceny;

            public Student(string name, int[] oceny)
            {
                Name = name;
                Oceny = oceny;
            }

            public double Average()
            {
                int suma = 0;
                for (int i = 0; i < Oceny.Length; i++)
                {
                    suma += Oceny[i];
                }

                return (double)suma / Oceny.Length;
            }

            public override string ToString()
            {
                return $"{Name} - {Average()}";
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Ania", new int[]{5, 4, 5}),
                new Student("Bartek", new int[]{3, 4, 4}),
                new Student("Cezary", new int[]{5, 5, 5}),
                new Student("Dorota", new int[]{4, 4, 4})
            };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            HighestAVG(students);

            InsertionSortByName(students);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            BinarySearchName(students, "Ania");
        }

        static void HighestAVG(Student[] students)
        {
            double maxAVG = students[0].Average();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Average() > maxAVG)
                {
                    maxAVG = students[i].Average();
                }
            }
            Console.WriteLine($"Highest AVG: {maxAVG}");
        }

        static void CountStudents(Student[] students){
            int count = 0;
            foreach(var student in students){
                if(student.Average() > 4.0){
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void InsertionSortByAVG(Student[] students)
        {
            for(int i = 1; i < students.Length; i++)
            {
                int j = i;
                if (students[j].Average() < students[j - 1].Average())
                {
                    (students[j], students[j-1]) = (students[j-1], students[j]);
                    j--;
                }
            }
        }

        static void BinarySearchName(Student[] students, string nameForSearch)
        {
            int left = 0;
            int right = students.Length - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;
                int result = string.Compare(students[mid].Name, nameForSearch);

                if(result == 0)
                {
                    Console.WriteLine($"Index of {nameForSearch} - {mid}");
                    return;
                }
                else if(result > 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }
    }
}
