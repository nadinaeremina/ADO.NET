using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.CodeFirst.Models;
using System.Data.Entity;

namespace EF.CodeFirst
{
    class Program
    {
        // можно установить EF через консоль:
        // Средства - диспетчер пакетов Nuget - консоль диспетчера пакетов (стоя в своем проекте)
        // 'Install + TAB - Package + EntityFramework (указать, что нужно установить)
        // далее создаем классы соответственно нашим таблицам (лучше создавать их в отдельной папке)

        // Помимо основных классов нужно еще создать наш класс db_Context, унаследованный от 'DbContext'
        //B 'connectionStrings' добавляем:
        //<connectionStrings>
        //	  <add name = "Book_add2" connectionString="Server=NADI\SQLEXPRESS;Database=Book_bd2;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
        //</connectionStrings>

        //И провайдер обяз-но:
        //<entityFramework>
        //    <providers>
        //      <provider invariantName = "System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
        //    </providers>
        //</entityFramework>


        static void Main(string[] args)
        {
            var db = new Book_db_Context(); // здесь наход-ся наши коллекции

            // создаем автора
            //Author al = new Author();
            //al.FN = "Ella";
            //al.LN = "Chornogor";
            //al.BD = new DateTime(2000, 01, 01);

            //db.Authors.Add(al); // добавляем в коллекцию авторов нашего нового автора
            // пока все сохраняется в оперативной памяти

            //db.SaveChanges(); // с оперативной памяти заливаем на БД

            // В БД возникает 'Migration history' - если выбрать первые 1000 строк - возникает при создании EF нашей
            // миграции (процесс изменения в стр-ре БД)
            // Если добавить запись - это не миграция, а если добавить таблицу, хранимую процедуру - это миграция

            Country c1 = new Country();
            c1.NameCountry = "Name1";

            db.Countries.Add(c1);
            db.SaveChanges();

            Console.ReadKey();

            // Чтобы посмотреть миграции - запускаем изменение миграций 
            // 'Enable-Migrations' - создалась папка миграций и прочитали одну миграцию 
            // создадим новую миграцию - 'add migration Add_country' ('Add_country' - придуманное имя)
            // в обозревателе решений появится наша миграция
            // в ней всегда два метода: 'up' - применяется, когда происходит миграция и в этом методе создается 
            // то действие, которое мы делали, а в 'down' - описывает, что нужно сделать, чтобы откатить транзакцию

            // дальше вносим изменения в нашу БД - 'Update-DataBase'

            // В отличие от 'Model First' 'Code First' не удаляет БД, а перезаписывает
        }
    }
}
