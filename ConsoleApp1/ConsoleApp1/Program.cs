using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public delegate void Sort_DataStructure();

    class Program
    {
        static void Main(string[] args) {
            Student newSt = new Student();
            newSt.AverageStudentGPA();
            Console.WriteLine("Avg gpa of 5 students is: "+newSt.AverageStudentGPA());
            
            newSt.PopulateStudentList();
        }
    }

    class Student
    {
        //List<string>[] StudentList = new List<string>[];
       string Student_name;
        string StudentID;
        double StudentGPA;
        
        // TODO: change this implementation so that the program pulls names from a Text File:
        // to do this, you must change the container for Student Names from Array to List
        
        string[] names = new string[5] { "Bill", "Mary", "Laura", "Sam", "Steve" };
        Random r1;

        public Student()
        {
            r1 = new Random();
            Student_name = names[r1.Next(0, 4)];
            StudentID = Convert.ToString(r1.Next(1000, 9999));
            StudentGPA = Convert.ToDouble(r1.Next(1, 4));
        }

        public double AverageStudentGPA()
        {
            // TO DO: implement the algorithm to calculate the Students' average GPA
            double avgGPA;
            avgGPA = StudentGPA;
            return avgGPA;
        }
        public void Run()
        {
            PopulateStudentList();
        }

        public void PopulateStudentList()
        {
            string[] lines = System.IO.File.ReadAllLines(@"U:\Users\732127\names.txt");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
         
    }

    public interface IDataStructure
    {
        void Sort();
    }

    class DataStructureQueue : IDataStructure
    {
        // the QUEUE holds the classes (that is classroom of students!)
        public Queue q1 = new Queue();

        Sort_DataStructure Sort1;

        public void Sorter()
        {
            // TO DO : sort the Queue 
        }

        public void Run()
        {
            for (int i = 0; i < 20; i++)
            {
                q1.Enqueue(new Student());
            }
            Sort1 = new Sort_DataStructure(Sorter);
        }
        public void Sort()
        {

        }

    }

    class DataStructureStack : IDataStructure
    {
        // the STACK holds the Students
        public Stack s1 = new Stack();

        Sort_DataStructure Sort1;

        public void Sorter()
        {
            // TO DO : sort the Stack
        }

        public void Run()
        {
            for (int i = 0; i < 20; i++)
            {
                s1.Push(new Student());
            }

            Sort1 = new Sort_DataStructure(Sorter);
        }

        public void Sort() { }
    }

}

namespace BubbleSort
{
    class MySort
    {
        static void Main2(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}