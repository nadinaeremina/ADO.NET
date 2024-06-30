using System;
using System.Data.SqlClient; // позволяет работать с СУБД Microsoft SQL
using System.Configuration; // подключаем через ссылки

namespace Introduction_ADO_net
{
    // Net.Framework включает в себя технологии: C#, Windows Forms, SQL, Ado.net + сетевое программирование

    // Net.Framework - среда разработки ПП для создания приложений в OS Wimdows

    // Мы будем работать в 6 версии - Net6, есть еще одна ветвь 'Net.Core' (сейчас называется просто 'Net')
    // - это кроссплатформенная реализация, еще яв-ся открытим кодом, н-р, на 'Github'

    // Ado.Net - это часть Dot.Net, нужен для работы с БД

    // класс Провайдер позволит установить нам соединение с конкретной БД,
    // выполнить все запросы, хранимые процедуры, вьюшки, функции и извлечь данные
    // как рез-т вып-ия запроса куда-то для клиента, чтобы он мог с ними работать
    // обработка БД бдет происходить в C#, а визуализация - в Windows Forms/WPF

    // основые классы:
    // 1
    // DbConnection - нужен для тогго, чтобы правильно выполнить подключение к серверу и базе

    // 2
    // DbCommand - отвечает за то, что будет делать SQL-сервер для того, чтобы сформировать
    // нужную команду, в кач-ве пар-ра будет строка

    // 3
    // DbDataReader

    // 4
    // DbDataAdapter

    // DataTable
    // DataSet

    // Режимы:
    // соединенный режим
    // отсоединенный режим

    // Модели:
    // DBFirst
    // ModelFirst
    // Codefirst

    // DataLayer
    // Link_to_Sql
    // Link_to_xaml
    // Async

    class Program
    {
        static void Main(string[] args)
        {
            // System.Data - работа с БД - базовое пространство для работы

            ///////////////////////////////////////Соединенный режим://///////////////////////////////////////////
            //
            ///////////////////////////////// 1 /////////////////////////////////////////////
            // Connection - подключимся к БД // Соединение происходит через класс Sql-connection

            // Trusted Connection
            // Server = myServerAddress; Database = myDataBase; Trusted_Connection = True;
            // 'myServerAddress' - имя нашего сервера, 'myDataBase' - имя БД,
            // Trusted_Connection = True - использование аутентификации через Windows

            // Standard Security
            // Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;
            // проверка подлинности Sql-сервера - 'user', 'password' - наш юзер и пароль

            // Server = myServerAddress; Database = myDataBase; Trusted_Connection = True;

            //string connectionstring = @"Server = NADI\SQLEXPRESS; Database = Academy; Trusted_Connection = True;";

            ///////////// 3 варианта подключения к нашему серверу и нашей БД://///////////////

            // 1 ctor
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = connectionstring; // инициализируем нашей строкой
            //conn.Open();

            // если через отладку состояние 0 - closed (подключение закрыто)
            // 1 - open (подключение открыто)
            // 2 - connecting (зависшее подключение)
            // 4 - execute (подключили, идет вып-ие команды)
            // 8 - fetching (об-т аодключения получает данные, кот. необ-мо считать)
            // 16 - broken (подключение к данным разорвано)

            // 2 ctor
            //SqlConnection conn = new SqlConnection(connectionstring);
            //conn.Open();

            // 3 ctor
            // исп-ем не строку, а строковый литерал
            //SqlConnection conn = new SqlConnection(@"Server = NADI\SQLEXPRESS; Database = Academy; Trusted_Connection = True;");
            //conn.Open();

            //////////////////////////////////////// 2 ////////////////////////////////////
            // Query - создать необходимые запросы для обработки данных
            // будем читать данные из таблицы

            // создаем комманду
            //string sqlcommand = "select * from [Academy].[dbo].[Teachers]";
            // 1 уровень - база, 2 уровень - схема, 3 уровень - таблица

            // создаем об-т SQL-command (команду)
            // SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            // 1 - строка команды, 2 - об-т подключения

            ///////////////////////////////////3///////////////////////////////////////////
            //Read query data - чтение данных их тех запросов, которые мы создали

            // 3 ф-ции:
            //1// ExecuteReader - запрос будет возвращать записи (таблицу) - об-т класса SqlDataReader

            //SqlDataReader dr = cmd.ExecuteReader(); // где 'dr' - таблица

            //while (dr.Read()) // читать до конца
            //{
            //    var f0 = dr[0];
            //    var f3 = dr[3];
            //    var f2 = dr[2];
            //    var f5 = dr[5];
            //    Console.WriteLine($"{f0, 4} {f3, 4} {f2, 4} {f5, 4}");
            //}

            //2// ExecuteNonQuery - ничего не возвращается (когда удаление, вставка или удаление)
            // возвращает 'int' - кол-во затронутых строк

            //string sqlcommand = "INSERT INTO [dbo].[Subjects] ([Name_]) VALUES ('Subject_10')";
            //SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            //int res = cmd.ExecuteNonQuery(); // тк 'ExecuteNonQuery' возвращает 'int' - создаем переменную
            //Console.WriteLine("Ok");

            //3// Executescalar - когда возвращается 1 скалярное значение

            //string sqlcommand = "select sum(Salary) as SalaryTotal from [dbo].[Teachers]"; 
            //SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            //object res = cmd.ExecuteScalar();
            //Console.WriteLine($"Salary total={res}");

            //conn.Close(); // соединение закрыли

            // Это все был присоединенный режим
            // Отсоединенный режим - присоединиться и считать данные, н-р, в оперативную память, закрываем
            // connect и обрабатываем наши данные как копии данных
            // а если нужно добавить, удалить, обновить данные, то тогда мы опять подключимся к БД
            // и изменения, кот. мы произвели переносим на БД

            // берем строку для соединения не ту, которая яв-ся строковым литералом, а ту, кот. прописана в 'App.config'
            // < connectionStrings >< add name = "Academy_add" connectionString = "Server = NADI\SQLEXPRESS; Database = Academy; Trusted_Connection = True;" />

            // нужно подключить using System.Configuration; (и в ссылках тоже)
            // подключаем по названию 'connectionStrings' - 'Academy_add' через класс 'ConfigurationManager'

            string connectionstring = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString;
            //можно исп-ть индекс в массиве подключений
            //string connectionstring = ConfigurationManager.ConnectionStrings[0].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                //Task
            }

            // соединение можно не закрывать
        }
    }
}
