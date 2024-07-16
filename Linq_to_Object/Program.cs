using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;
using System.Threading;

namespace Linq_to_Object
{
    class Program
    {
        public static void Func_student_linq(List<Student> students)
        {
            Random rnd = new Random();
            // создали кол-цию стран
            string[] city = { "c2", "c4", "c5", "c10", "c1", "c123", "c45" };

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                // добавляем фио - просто i-тый эл-т, а город рандомим
                students.Add(new Student { FN = "N" + i, LN = "LN" + i, City = city[rnd.Next(0, city.Length - 1)], Age = rnd.Next(16, 55) });
            }

            foreach (Student student in students)
                Console.WriteLine(student);
        }

        public static void Find_linq_student(List<Student> students)
        {
            var res = from s in students
                      where s.Age >= 30
                      orderby s.Age
                      select new { s.LN, s.Age };
            // выдаем студентов, у которых покажем только фамилию и возраст

            foreach (var r in res)
                Console.WriteLine(r);
        }

        public static void Avg_age_linq(List<Student> students)
        {
            //var avg_age = students.Average(s => s.Age); // 1 способ
            var avg_age = students.Select(s => s.Age).Average(); // 2 способ
            Console.WriteLine(avg_age);
        }

        public static void Min_age_linq(List<Student> students)
        {
            //int min_age = students.Min(s => s.Age); // 1 способ
            int min_age = students.Select(s => s.Age).Min(); // 2 способ
            // просматриваем всех студенотов по полю 'Age' и применяем метод 'Min'
            
            Console.WriteLine(min_age);

            var st = students.First(s => s.Age == min_age);
            // метод 'Fist' - возврвщвет первый эл-т послед-ти с мин возрастом
            //var st = students.Where(s => s.Age == min_age);
            // метод 'Where' - возврвщвет всю послед-ть эл-ов с мин возрастом

            Console.WriteLine(st);

            //foreach (var item in st)
                //Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            // 1 // Коллекция массивов

            ////// 1 // работаем с коллекцией без БД
            //string[] color = { "red", "green", "blue", "red", "yellow", "black", "blue", "brown", "green", "yellow" };

            //var res = from c in color // 'c' - каждый эл-т
            //          where c.Length > 3
            //          select c;

            //foreach (var item in res)
            //    Console.WriteLine(item);

            //Console.WriteLine("------------------------------------------------------");

            //////2
            //var res2 = (from c in color
            //           where c.Length > 3
            //           orderby c.Length descending 
            //           select c).Distinct(); // 'Distinct' - только уникальные значения

            //foreach (var item in res2)
            //    Console.WriteLine(item);

            // 2 обьект - класс

            List<Student> students = new List<Student>();

            Func_student_linq(students);

            Console.WriteLine("++++++++++++++++++++++++++++");

            Find_linq_student(students);

            Console.WriteLine("++++++++++++++++++++++++++++");

            Avg_age_linq(students);

            Console.WriteLine("++++++++++++++++++++++++++++");

            Min_age_linq(students);
        }
    }
}
