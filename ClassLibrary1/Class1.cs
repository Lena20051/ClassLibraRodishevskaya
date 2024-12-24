// CollegeLibrary.dll
// Автор: <Родишевская Елена 31 ИС>

using System;
using System.Collections.Generic;
using System.Linq;

namespace CollegeLibrary
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Course { get; set; }

        public Teacher(string name, string course)
        {
            Name = name;
            Course = course;
        }

        public void Show()
        {
            Console.WriteLine($"  Имя: {Name}, Дисциплина: {Course}");
        }
    }

    public class College
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Teacher> Teachers { get; set; }

        public College(string name, string address)
        {
            Name = name;
            Address = address;
            Teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void ShowAll()
        {
            Console.WriteLine($"Колледж: {Name}, Адрес: {Address}");
            Console.WriteLine("Преподаватели:");
            if (Teachers == null || Teachers.Count == 0)
            {
                Console.WriteLine("Список преподавателей пуст");
            }
            else
            {
                foreach (var teacher in Teachers)
                {
                    teacher.Show();
                }
            }

        }

        public void ShowAllSorted(Comparison<Teacher> comparison)
        {
            Console.WriteLine($"Колледж: {Name}, Адрес: {Address}");
            Console.WriteLine("Отсортированные преподаватели:");
            if (Teachers == null || Teachers.Count == 0)
            {
                Console.WriteLine("Список преподавателей пуст");
            }
            else
            {
                Teachers.Sort(comparison);
                foreach (var teacher in Teachers)
                {
                    teacher.Show();
                }
            }
        }
    }
}
