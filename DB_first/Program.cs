using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_first.DataLayer;
using DB_first.Model;

namespace DB_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // база уже создана, через 'DBFist' - читаем данные, обрабатываем и тд

            // подключаем 'Entity Framework'
            // добавить элемент 'Model ADO.net EDM'
            // выбираем 'пустая модель'
            // создать соединение
            // 'имя серверв' - обновить/прописать
            // 'Проверка подлинности' - 'проверка подлинности Windows'
            // 'Сертификат сервера' - галочка
            // 'введите имя базы' - прописываем
            // 'далее'
            // можем выбрать таблицы, представления и хранимые процедуры, которые нам нужны, 

            // 'Model' - 'ModelContext' - Company_DBEntities' (создался класс, сущности)
            // Есть созданные классы - 'Customers' и тд

            var db = new Company_DBEntities();

            // All
            IEnumerable<Customer_model> models = DL.Customer.Customer_All();

            foreach (var model in models)
                Console.WriteLine(model);

            Console.WriteLine("_____________________________________________");

            // ById 
            Customer_model customer = DL.Customer.ByID(2);
            Console.WriteLine(customer);

            // Если хотим добавить еще табличек - в 'Model.edmx' - правой кнопкой - обновить модель из БД
            // Выбираем нужные таблицы и хранимки

            // Если хотим удалить хранимку - в 'Model.edmx' - правой кнопкой - браузер моделей
            // Справа в меню - 'функции импорта' - из списка можно удалить, также удаляем из 'сложные типы'
            // И удалить из проекта в 'Model.tt' и 'сохранить все'
        }
    }
}
