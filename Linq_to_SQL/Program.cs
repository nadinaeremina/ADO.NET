using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq_to_SQL;
using System.Data.SqlClient;
using System.Configuration;
using Linq_to_SQL.Entity;

namespace Linq_to_SQL
{/*
  * LINQ - интегрированный язык запросов
    LINQ - расширение,кот создавалось под воздействием языка SQL, хорошо зарекомендовало себя при работе с данными
    в реляционных БД, предназначен для работы с очень большими коллекциями обьектов, используя механизм
    создания запросов языка С#

    Разновидности LINQ:
    - Linq to Object - работа с коллекциями, хранящимися в оперативной памяти
    - Linq to SQL - работа с данными в реляционной БД
    - Linq to XML - работа с XAML-файлами

    Интерфейсы:
    - IEnumerable
    - IQueryable

    Подключаем пространство имен 'System.Data.Linq' (нужна ссылка)
*/
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////// Linq to SQL ///////////////////////////////
            // 1 ///////// Простые запросы, которые используют текст запроса ///////////

            // All Teachers // посмотреть всех учителей

            string connectionstring = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString;

            // чтобы работать с таблицами в БД как с источником Ling - нам нужно создать класс 'DataContext'
            using (DataContext db = new DataContext(connectionstring))
            {
                //// если мы используем linq - значит мы хотим работать с коллекциями,
                //// значит нам нужна коллекция, у нас она будет типа 'Table'
                Table<Teacher> teachers = db.GetTable<Teacher>();
                //// мы подключились к БД и можем читать сущность 'Teacher'
                //// скачали копию всей таблички

                //foreach (Teacher item in teachers)
                //    Console.WriteLine(item);

                // Teacher by id

                //// 1
                //var query = from t in teachers
                //            where t.Id == 5
                //            select t;

                //// 2
                //var query = from t in teachers
                //            where t.Salary > 8000
                //            select t;

                //// 3
                //var query = from t in teachers
                //            where t.Surname.StartsWith("Л")
                //            orderby t.Surname
                //            select t;

                //foreach (Teacher item in query)
                //    Console.WriteLine(item);
                ////если хотим другие поля отображать в выводе
                ////Console.WriteLine($"{item.Name_} {item.Salary}"); 

                // 2 ////////////////////////// Предикаты /////////////////////////////

                //// 1 
                // var res = teachers.Where(t => t.Id == 10);
                //// приниает учителя, проверяет 'id' и если возвращает 'true' - отправляет в 'res'

                //// 2
                //var res = teachers.Where(t => t.Surname.StartsWith("Л")).ToList();
                //// 'ToList()' нам нужен для того, чтобы: мы понимали, что у нас будет кол-ция
                //// явное преобразование 'var' к 'list', если дальше хотим работать с 'List'

                //foreach (Teacher item in res)
                //Console.WriteLine(item);

                //////// через List

                //List<Teacher> res2 = teachers.Take(3).ToList();
                //// 'Take' - сколько брать учителей

                //foreach (Teacher item in res2)
                //Console.WriteLine(item);

                /////////////////////////////// insert ////////////////////////////////

                //// создаем нового тичера
                //Teacher t_new = new Teacher
                //{
                //    EmploymentDate = DateTime.Now,
                //    IsAssistant = false,
                //    PositionId = 2,
                //    IsProfessor = true,
                //    Name_ = "teacher_new",
                //    Surname = "Surname_new",
                //    Premium = 100,
                //    Salary = 5000
                //};

                ////// методом 'InsertOnSubmit' добавляем учителя в оперативную память
                //teachers.InsertOnSubmit(t_new);
                ////// обновляем // перезаливаем данные обратно на сервер
                //db.SubmitChanges();

                //foreach (Teacher item in teachers)
                //    Console.WriteLine(item);

                //////////////////////////////// update ///////////////////////////////

                //Teacher teacher_update = teachers.Where(t => t.Id == 1).First();
                ////// обновляем отдельное св-во найденного тичера
                //teacher_update.Surname = "new Chornogor";

                //db.SubmitChanges();
                //Console.WriteLine(teacher_update);

                /////////////////////////////// delete /////////////////////////////////

                Teacher teacher_delete = teachers.Where(t => t.Id == 78).First();
                //// если нужна кол-ция, то First() - не нужен

                //// если удаляем один об-т - 'DeleteOnSubmit', если неск-ко - 'DeleteAllOnSubmit'
                teachers.DeleteOnSubmit(teacher_delete);

                db.SubmitChanges();

                foreach (Teacher item in teachers)
                    Console.WriteLine(item);
            }
        }
    }
}
