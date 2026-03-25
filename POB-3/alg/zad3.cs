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

        static void BubbleSortByAVG(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (students[j].Average() > students[j + 1].Average())
                    {
                        (students[j], students[j + 1]) = (students[j + 1], students[j]);
                    }
                }
            }
        }

        static void SelectionSortByAVG(Student[] students)
        {
            for(int i = 0; i < students.Length - 1; i++)
            {
                int index = i;
                for(int j = i + 1; j < students.Length; j++)
                {
                    if (students[index].Average() > students[j].Average())
                    {
                        index = j;
                    }
                }
                (students[i], students[index]) = (students[index], students[i]);
            }
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

        static void MergeSortByAVG(Student[] students)
        {
            if(students.Length <= 1) return;
            int mid = students.Length / 2;

            Student[] left = new Student[mid];
            Student[] right = new Student[students.Length - mid];

            Array.Copy(students, 0, left, 0, mid);
            Array.Copy(students, mid, right, 0, students.Length - mid);

            MergeSortByAVG(left);
            MergeSortByAVG(right);

            int i = 0, j = 0, k = 0;
            while(i < left.Length && j < right.Length)
            {
                if (left[i].Average() < right[j].Average())
                {
                    students[k++] = right[j++];
                }
                else
                {
                    students[k++] = left[i++];
                }
            }

            while(i < left.Length)
            {
                students[k++] = left[i++];
            }
            while(j < right.Length)
            {
                students[k++] = right[j++];
            }
        }

        static void InsertionSortByName(Student[] student)
        {
            for(int i = 1; i  < student.Length; i++)
            {
                int j = i;
                while (j > 0 && string.Compare(student[j].Name, student[j - 1].Name) < 0)
                {
                    (student[j], student[j - 1]) = (student[j - 1], student[j]);
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
