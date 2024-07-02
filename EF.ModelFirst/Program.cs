using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EF.ModelFirst
{
    /*
'Entity Framework' - готовый функционал, кот. позволит автом-ки и более эф-но исп-ть
подключение к БД и работать с данными.

- обьектная модель - группа данных (связанных м/у собой классов) приложения, 
кот. исп-ся для хранения данных из БД - каждая таблица данных в С# будет представлена классом.
Сама модель - это и есть наша обьектная модель.

- концептуальная модель - классы приложения и взаимоотношения м/у ними. 
'ORM' - object relation mapping - отображение обь-ов, связанных в таблице - Диаграмма таблиц.

- Отображение (mapping) - схема, кот. содержит связь м/у концептуальной моделью и обьектной моделью.

--------------Модель данных ('EDM' - Entity data model = Conceptual Model+Mapping+Storage Model)----------------
На ней основан весь Framework, описывает взаимоотношения обьектов классов приложения и таблиц в БД.


1) DB First - Data Base First - при этом подходе база данных уже сущ-ет.
На основе этой БД мы строим модель 'EDM", кот. будет строиться благодаря технологии 'Entity Framework'.
Она будет строить нам классы в соответствии с нашими табличками, эти классы будут наз-ся 'сущности', 
обработку данных будем вып-ть через эти классы в модельке. Это фундамент данного приложения.

2) MF - Model First - базы не сущ-ет, ее нужно сначала создать. Сначала создаем модель EDM. 
На снове модели будем создавать БД на сервере.

3) CF - Code First - сначачла создание всех класссов, кот. явл-ся сущностями нашей будущей БД.
На основе классов через 'Entity Framework' будем строить модельку 'EDM', кот. на основе классов
создаст сущности - таблички, а потом создадим чере 'Entity Framework' БД.
Здесь классы мы создаем самостоятельно. На их основе EF построит модельку, создаст сущности, привяжет ключи, 
а затем на основе модельки создаст БД.


Подключаем 'Entity Framework' через 'пакет'  'управление пакетами' или через 'ср-ва' 'диспетчер пакетов'
- добавляем ссылку - 'System.configuration' и подключаем 'using'
- добавляем элемент - 'модель ADO.net EDM'

- появляется 'package config' - пишет, что пакет был установлен
- добавятся 2 ссылки 'EF' и 'EF на SQL-сервер'
- добавить - создать эл-т - модель ADO.net EDM
- выбираем 'пустая модель', потому что у нас 'Model First'


- Св-во сущности - это поле
- Св-во навигации - это связи


После создания сущностей - 'сформировать БД на основе моделей' - 'Создать соединение' - вводим имя серверв
- выбрать БД, если она есть, тк у нас ее еще нет - мы придумываем имя
 Далее увидим скрипт создания БД - нажимаем 'готово'

В 'app' добавился 'connectionstrings' - самостоятельно, не нужно писать руками.

Создался файл 'sql' со скриптом.

Создался 'Model' - в файле 'Model Context' в файле 'cs' мы вмдим структуру:
'DbContext' - базовый класс, на основе которого создается наш класс 'ContextModel', кон-р у него
от нашей модельки. Мы видим классы 'DBSet' - классы, кот. определяют кол-цию записей в таблице.
(Например, 'авторы', 'книги' и тд)
В 'Model.tt' мы видим все эти классы отдельно. И увидим их ключи внешние.

В нашем скрипте нажимаеи 'треугольник' - выполнить запрос. В БД появится наша БД и все таблички.

Если мы чтото меняем в нашей модели - после изменений - 'обновить модель из БД'. 'Обновить' - 
Обновление происходит с теми данными, кот. у нас уже есть, а сели мы что-то добавили - выбираем 'добавить'.
Это неправильный вариант!!! - Нужно выбрать снова 'сформировать БД на основе моделей' - создастся новый скрипт.
 
Если мы просто обновим - у нас старая БД удалится, а вместо нее оздастся новая.
Если в БД уже были данные - они будут уничтожены. Поэтому если мы хотим данные сохранить - нам нужно
отредактировать скрипт. Комментим старый скрипт, добавляем изменения и выполняем запрос.

 */
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Publisher_add"].ConnectionString;

            ///////////////////////////////////////// 1 ///////////////////////////////////////

            //string sqlcommand_1 = "INSERT INTO [Publisher].[dbo].[CountrySet] ([NameCountry]) values ('Russia')",
            //       sqlcommand_2 = "INSERT INTO [Publisher].[dbo].[CountrySet] ([NameCountry]) values ('USA')",
            //       sqlcommand_3 = "INSERT INTO [Publisher].[dbo].[CountrySet] ([NameCountry]) values ('England')";

            //using (SqlConnection conn = new SqlConnection(connectionstring))
            //{
            //    conn.Open();

            //    SqlCommand cmd_1 = new SqlCommand(sqlcommand_1, conn);
            //    int res_1 = cmd_1.ExecuteNonQuery();

            //    SqlCommand cmd_2 = new SqlCommand(sqlcommand_2, conn);
            //    int res_2 = cmd_2.ExecuteNonQuery();

            //    SqlCommand cmd_3 = new SqlCommand(sqlcommand_3, conn);
            //    int res_3 = cmd_3.ExecuteNonQuery();

            //    Console.WriteLine("Ok");
            //}

            ///////////////////////////////////////// 2 ///////////////////////////////////////

            //string sqlcommand_1 = "INSERT INTO [Publisher].[dbo].[CitySet] ([NameCity], [CountryId]) values ('Moscow', 1)",
            //       sqlcommand_2 = "INSERT INTO [Publisher].[dbo].[CitySet] ([NameCity], [CountryId]) values ('Vashington', 2)",
            //       sqlcommand_3 = "INSERT INTO [Publisher].[dbo].[CitySet] ([NameCity], [CountryId]) values ('London', 3)";

            //using (SqlConnection conn = new SqlConnection(connectionstring))
            //{
            //    conn.Open();

            //    SqlCommand cmd_1 = new SqlCommand(sqlcommand_1, conn);
            //    int res_1 = cmd_1.ExecuteNonQuery();

            //    SqlCommand cmd_2 = new SqlCommand(sqlcommand_2, conn);
            //    int res_2 = cmd_2.ExecuteNonQuery();

            //    SqlCommand cmd_3 = new SqlCommand(sqlcommand_3, conn);
            //    int res_3 = cmd_3.ExecuteNonQuery();

            //    Console.WriteLine("Ok");
            //}

            ///////////////////////////////////////// 3 ///////////////////////////////////////

            //string sqlcommand_1 = "INSERT INTO [Publisher].[dbo].[AuthorSet] ([FN], [LN], [CountryId]) values ('Alexandr', 'Pushkin', 1)",
            //       sqlcommand_2 = "INSERT INTO [Publisher].[dbo].[AuthorSet] ([FN], [LN], [CountryId]) values ('Mark', 'Tven', 2)",
            //       sqlcommand_3 = "INSERT INTO [Publisher].[dbo].[AuthorSet] ([FN], [LN], [CountryId]) values ('Willam', 'Schekspir', 3)";

            //using (SqlConnection conn = new SqlConnection(connectionstring))
            //{
            //    conn.Open();

            //    SqlCommand cmd_1 = new SqlCommand(sqlcommand_1, conn);
            //    int res_1 = cmd_1.ExecuteNonQuery();

            //    SqlCommand cmd_2 = new SqlCommand(sqlcommand_2, conn);
            //    int res_2 = cmd_2.ExecuteNonQuery();

            //    SqlCommand cmd_3 = new SqlCommand(sqlcommand_3, conn);
            //    int res_3 = cmd_3.ExecuteNonQuery();

            //    Console.WriteLine("Ok");
            //}

            ///////////////////////////////////////// 4 ///////////////////////////////////////

            //string sqlcommand_1 = "INSERT INTO [Publisher].[dbo].[BookSet] ([Title], [Page], [Price], [AuthorId]) values ('Evgeny Onegin', '100', 500, 2)",
            //       sqlcommand_2 = "INSERT INTO [Publisher].[dbo].[BookSet] ([Title], [Page], [Price], [AuthorId]) values ('Adventures of Tom Soyer', '300', 1000, 3)",
            //       sqlcommand_3 = "INSERT INTO [Publisher].[dbo].[BookSet] ([Title], [Page], [Price], [AuthorId]) values ('Romeo and Juilett', 500, 1500, 4)";

            //using (SqlConnection conn = new SqlConnection(connectionstring))
            //{
            //    conn.Open();

            //    SqlCommand cmd_1 = new SqlCommand(sqlcommand_1, conn);
            //    int res_1 = cmd_1.ExecuteNonQuery();

            //    SqlCommand cmd_2 = new SqlCommand(sqlcommand_2, conn);
            //    int res_2 = cmd_2.ExecuteNonQuery();

            //    SqlCommand cmd_3 = new SqlCommand(sqlcommand_3, conn);
            //    int res_3 = cmd_3.ExecuteNonQuery();

            //    Console.WriteLine("Ok");
            //}

            ///////////////////////////////////////// 5 ///////////////////////////////////////

            //string sqlcommand_1 = "INSERT INTO [Publisher].[dbo].[PublisherSet] ([PublisherName], [BookId], [CountryId]) values ('Nebo', 1, 1)",
            //       sqlcommand_2 = "INSERT INTO [Publisher].[dbo].[PublisherSet] ([PublisherName], [BookId], [CountryId]) values ('Avenu', 2, 2)",
            //       sqlcommand_3 = "INSERT INTO [Publisher].[dbo].[PublisherSet] ([PublisherName], [BookId], [CountryId]) values ('Roll', 3, 3)";

            //using (SqlConnection conn = new SqlConnection(connectionstring))
            //{
            //    conn.Open();

            //    SqlCommand cmd_1 = new SqlCommand(sqlcommand_1, conn);
            //    int res_1 = cmd_1.ExecuteNonQuery();

            //    SqlCommand cmd_2 = new SqlCommand(sqlcommand_2, conn);
            //    int res_2 = cmd_2.ExecuteNonQuery();

            //    SqlCommand cmd_3 = new SqlCommand(sqlcommand_3, conn);
            //    int res_3 = cmd_3.ExecuteNonQuery();

            //    Console.WriteLine("Ok");
            //}
        }
    }
}
