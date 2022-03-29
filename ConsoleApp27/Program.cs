using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(12);
            Student stu2 = new Student(30);
            Teacher tch1 = new Teacher(500);
            Teacher tch2 = new Teacher(600);
            Console.WriteLine(stu1 > stu2);
        }
    }
    abstract class Person
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string ShowInfo { get; set; }

    }

    //public  static void ShowInfo()
    // {
    //     return;
    // }
    class Student : Person
    {
        private Student()
        {
            int _id;
            int Id;
            _id = 0;
            ++_id;
            Id = _id;
        }

        public double Point { get; set; }
        public Student(double point)
        {
            this.Point = point;
        }
        public static bool operator >(Student stu1, Student stu2)
        {
            return stu1.Point > stu2.Point;
        }
        public static bool operator <(Student stu1, Student stu2)
        {
            return stu1.Point < stu2.Point;
        }
    }
    class GroupMate : Person
    {
        public Student[] arry = { };
        public static void Sort()
        {

        }

    }
    class Teacher : Person
    {
        public double Salary { get; set; }
        public Teacher(double salary)
        {
            this.Salary = salary;
        }
        public static bool operator >(Teacher tch1, Teacher tch2)
        {
            return tch1.Salary > tch2.Salary;
        }
        public static bool operator <(Teacher tch1, Teacher tch2)
        {
            return tch1.Salary > tch2.Salary;
        }
    }
}
        
    

