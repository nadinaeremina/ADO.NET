using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Exam.Models;
using Exam.Data_Layer_folder;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //var db = new EventsDbContext();

            //Event_category event_cat = new Event_category();
            //event_cat.Title = "Спектакль";

            //Event_name event_name = new Event_name();
            //event_name.Title = "Левша";
            //event_name.event_category = event_cat;

            //Country country = new Country();
            //country.Title = "Россия";

            //City city = new City();
            //city.Title = "Санкт-Петербург";
            //city.country = country;

            //Place place_1 = new Place();
            //place_1.Title = "ДК им.Ленсовета";
            //place_1.city = city;

            //Event_content event_con = new Event_content();
            //event_con.event_name = event_name;
            //event_con.Date = new DateTime(2024, 06, 21);
            //event_con.place = place_1;
            //event_con.Time = Convert.ToDateTime("18:25:00");
            //event_con.Description = "Левша";
            //event_con.Min_age = 7;
            //event_con.Max_tickets = 700;
            //event_con.Sold_tickets = 700;

            //Client client_1 = new Client();
            //client_1.First_name = "Иван";
            //client_1.Last_name = "Иванов";
            //client_1.Middle_name = "Иванович";
            //client_1.Email = "ivan1@mail.ru";
            //client_1.Birthday = new DateTime(2000,03,12);

            //Buy_ticket buy_ticket = new Buy_ticket();
            //buy_ticket.Value = 5000;
            //buy_ticket.date_of_bought = new DateTime(2024,06,22);
            //buy_ticket.client = client_1;
            //buy_ticket.event_name = event_name;

            //db.event_categories.Add(event_cat);
            //db.event_Names.Add(event_name);
            //db.countries.Add(country);
            //db.cities.Add(city);
            //db.places.Add(place_1);
            //db.event_Contents.Add(event_con);
            //db.clients.Add(client_1);
            //db.buy_Tickets.Add(buy_ticket);

            //db.SaveChanges();

            //1
            //string[] ev_cat = { "Концерт", "Выставка", "Цирк", "Спорт", "Семинапы и тренинги", "Кино", "Юмор", "Вечеринки", "Детям", "Другое" };

            //foreach (string item in ev_cat)
            //    Date_Layer_model.Event_category.Insert(item);

            //2
            //Date_Layer_model.Country.Insert("Казахстан");

            //3
            //string[] cities = { "Москва", "Алматы", "Астана"};

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    if (i >= 1)
            //        Date_Layer_model.City.Insert(cities[i], 2);
            //    else
            //        Date_Layer_model.City.Insert(cities[i], 1);
            //}

            //4
            //List<Client_model> clients = new List<Client_model> ();
            //clients.Add(new Client_model("Петр", "Афаеасьев", "Иванович", "alt3@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Афанасий", "Петров", "Иванович", "alt4@mail.ru", new DateTime(2000, 04, 12)));
            //clients.Add(new Client_model("Николай", "Солнцев", "Иванович", "alt5@mail.ru", new DateTime(2002, 04, 12)));
            //clients.Add(new Client_model("Иван", "Мезенцев", "Иванович", "alt6@mail.ru", new DateTime(2003, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Богатырский", "Иванович", "alt7@mail.ru", new DateTime(2004, 04, 12)));
            //clients.Add(new Client_model("Семен", "Носков", "Иванович", "alt8@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Леонов", "Иванович", "alt9@mail.ru", new DateTime(2000, 04, 12)));
            //clients.Add(new Client_model("Мария", "Книжкина", "Ивановна", "alt10@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Елена", "Ручкина", "Ивановна", "alt11@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Анастасия", "Тетрадкина", "Ивановна", "alt12@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Лариса", "Полетина", "Ивановна", "alt13@mail.ru", new DateTime(2004, 04, 12)));
            //clients.Add(new Client_model("Юлия", "Лескина", "Ивановна", "alt14@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Валентина", "Почкина", "Ивановна", "alt15@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Галина", "Любимова", "Ивановна", "alt16@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Половинкина", "Ивановна", "alt17@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Шилова", "Ивановна", "alt18@mail.ru", new DateTime(2002, 04, 12)));
            //clients.Add(new Client_model("Семен", "Слепаков", "Иванович", "alt19@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Разумова", "Ивановна", "alt20@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Гнетнев", "Иванович", "alt21@mail.ru", new DateTime(2008, 04, 12)));
            //clients.Add(new Client_model("Петр", "Петров", "Иванович", "alt22@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Переворот", "Ивановна", "alt23@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Малышкин", "Иванович", "alt24@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Лапочкина", "Ивановна", "alt25@mail.ru", new DateTime(2002, 04, 12)));
            //clients.Add(new Client_model("Никита", "Сергеев", "Иванович", "alt26@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Енисеева", "Ивановна", "alt27@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Ветров", "Иванович", "alt28@mail.ru", new DateTime(2015, 04, 12)));
            //clients.Add(new Client_model("Иван", "Метелкин", "Иванович", "alt29@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Денис", "Маслов", "Иванович", "alt3@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Ильясов", "Иванович", "alt31@mail.ru", new DateTime(2000, 04, 12)));
           
            //clients.Add(new Client_model("Альберт", "Соколов", "Иванович", "alt32@mail.ru", new DateTime(2008, 04, 12)));
            //clients.Add(new Client_model("Петр", "Алладинов", "Иванович", "alt33@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Афанасий", "Повозов", "Иванович", "alt34@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Сахаров", "Иванович", "alt35@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Молоков", "Иванович", "alt36@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Болотов", "Иванович", "alt37@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Новаторов", "Иванович", "alt38@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Лапушкин", "Иванович", "alt39@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Кожевников", "Ивановна", "alt40@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Елена", "Роботова", "Ивановна", "alt41@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Анастасия", "Тапочкина", "Ивановна", "alt42@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Лариса", "Пчелкина", "Ивановна", "alt43@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Юлия", "Лолина", "Ивановна", "alt44@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Валентина", "Тапочкина", "Ивановна", "alt45@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Галина", "Ломтева", "Ивановна", "alt46@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Перепелкина", "Ивановна", "alt47@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Шикова", "Ивановна", "alt48@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Селиванов", "Иванович", "alt49@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Росина", "Ивановна", "alt50@mail.ru", new DateTime(2002, 04, 12)));
            //clients.Add(new Client_model("Борис", "Гоголь", "Иванович", "alt51@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Петров", "Иванович", "alt52@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Петрова", "Ивановна", "alt53@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Макушев", "Иванович", "alt54@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Лузина", "Ивановна", "alt55@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Никита", "Соснин", "Иванович", "alt56@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Еремеева", "Ивановна", "alt57@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Вовин", "Иванович", "alt58@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Власов", "Иванович", "alt59@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Денис", "Путин", "Иванович", "alt60@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Иполов", "Иванович", "alt61@mail.ru", new DateTime(2001, 04, 12)));

            //clients.Add(new Client_model("Альберт", "Сенов", "Иванович", "alt62@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Аллоев", "Иванович", "alt63@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Афанасий", "Поворов", "Иванович", "alt64@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Сахов", "Иванович", "alt65@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Молотов", "Иванович", "alt66@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Бобаев", "Иванович", "alt67@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Нолов", "Иванович", "alt68@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Лаков", "Иванович", "alt69@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Кожова", "Ивановна", "alt70@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Елена", "Рошова", "Ивановна", "alt71@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Анастасия", "Тапова", "Ивановна", "alt72@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Лариса", "Пчелова", "Ивановна", "alt73@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Юлия", "Лолаева", "Ивановна", "alt74@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Валентина", "Татова", "Ивановна", "alt75@mail.ru", new DateTime(2000, 04, 12)));
            //clients.Add(new Client_model("Галина", "Лорова", "Ивановна", "alt76@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Посохова", "Ивановна", "alt77@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Шилова", "Ивановна", "alt78@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Сегов", "Иванович", "alt79@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Ророва", "Ивановна", "alt80@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Гомов", "Иванович", "alt81@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Петлов", "Иванович", "alt82@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Пенина", "Ивановна", "alt83@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Маков", "Иванович", "alt84@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Луна", "Ивановна", "alt85@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Никита", "Сотин", "Иванович", "alt86@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Еремова", "Ивановна", "alt87@mail.ru", new DateTime(2002, 04, 12)));
            //clients.Add(new Client_model("Николай", "Волин", "Иванович", "alt88@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Влатов", "Иванович", "alt89@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Денис", "Пулин", "Иванович", "alt90@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Илин", "Иванович", "alt91@mail.ru", new DateTime(2001, 04, 12)));

            //clients.Add(new Client_model("Альберт", "Сонин", "Иванович", "alt92@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Апельсинов", "Иванович", "alt93@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Афанасий", "Пронин", "Иванович", "alt94@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Самин", "Иванович", "alt95@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Молин", "Иванович", "alt96@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Болин", "Иванович", "alt97@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Носков", "Иванович", "alt98@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Лютин", "Иванович", "alt99@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Кривова", "Ивановна", "alt100@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Елена", "Ролина", "Ивановна", "alt101@mail.ru", new DateTime(2003, 04, 12)));
            //clients.Add(new Client_model("Анастасия", "Татаева", "Ивановна", "alt102@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Лариса", "Полоева", "Ивановна", "alt103@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Юлия", "Лоснина", "Ивановна", "alt104@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Валентина", "Танатова", "Ивановна", "alt105@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Галина", "Лупина", "Ивановна", "alt106@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Пакова", "Ивановна", "alt107@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Шинина", "Ивановна", "alt108@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Солин", "Иванович", "alt109@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Родина", "Ивановна", "alt110@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Гобов", "Иванович", "alt111@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Пулин", "Иванович", "alt112@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Пенкин", "Ивановна", "alt113@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Манин", "Иванович", "alt114@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Лубина", "Ивановна", "alt115@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Никита", "Сомов", "Иванович", "alt116@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Екина", "Ивановна", "alt117@mail.ru", new DateTime(2004, 04, 12)));
            //clients.Add(new Client_model("Николай", "Воздухов", "Иванович", "alt118@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Вовов", "Иванович", "alt119@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Денис", "Пранков", "Иванович", "alt120@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Имоев", "Иванович", "alt121@mail.ru", new DateTime(2001, 04, 12)));

            //clients.Add(new Client_model("Альберт", "Супин", "Иванович", "alt122@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Арбузов", "Иванович", "alt123@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Афанасий", "Пупкин", "Иванович", "alt124@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Соболев", "Иванович", "alt125@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Мумин", "Иванович", "alt126@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Бунинн", "Иванович", "alt127@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Нуров", "Иванович", "alt128@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Ликинн", "Иванович", "alt129@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Комина", "Ивановна", "alt130@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Елена", "Русова", "Ивановна", "alt131@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Анастасия", "Талилоева", "Ивановна", "alt132@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Лариса", "Пупкина", "Ивановна", "alt133@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Юлия", "Лубринкина", "Ивановна", "alt134@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Валентина", "Томова", "Ивановна", "alt135@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Галина", "Пузоева", "Ивановна", "alt136@mail.ru", new DateTime(2002, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Панина", "Ивановна", "alt137@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Шушова", "Ивановна", "alt138@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Скоров", "Иванович", "alt139@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Рыбина", "Ивановна", "alt140@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Гунин", "Иванович", "alt141@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Песнин", "Иванович", "alt142@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Пилоеван", "Ивановна", "alt143@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Мамочкин", "Иванович", "alt144@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Лобстерова", "Ивановна", "alt145@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Никита", "Супнин", "Иванович", "alt146@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Елисеева", "Ивановна", "alt147@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Васин", "Иванович", "alt148@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Вороновв", "Иванович", "alt149@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Денис", "Пузыркин", "Иванович", "alt150@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Имамовв", "Иванович", "alt151@mail.ru", new DateTime(2001, 04, 12)));

            //clients.Add(new Client_model("Альберт", "Снегин", "Иванович", "alt152@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Ашоев", "Иванович", "alt153@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Афанасий", "Пувин", "Иванович", "alt154@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Солодов", "Иванович", "alt155@mail.ru", new DateTime(2003, 04, 12)));
            //clients.Add(new Client_model("Иван", "Морин", "Иванович", "alt156@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Билимбаев", "Иванович", "alt157@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Нирин", "Иванович", "alt158@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Лясов", "Иванович", "alt159@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Кочкина", "Ивановна", "alt160@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Елена", "Ринина", "Ивановна", "alt161@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Анастасия", "Тукина", "Ивановна", "alt162@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Лариса", "Порина", "Ивановна", "alt163@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Юлия", "Логинова", "Ивановна", "alt164@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Валентина", "Татарова", "Ивановна", "alt165@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Галина", "Помаева", "Ивановна", "alt166@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Пупсик", "Ивановна", "alt167@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Шансонова", "Ивановна", "alt168@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Соснин", "Иванович", "alt169@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Ракова", "Ивановна", "alt170@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Голин", "Иванович", "alt171@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Пупов", "Иванович", "alt172@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Пурина", "Ивановна", "alt173@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Макова", "Иванович", "alt174@mail.ru", new DateTime(2004, 04, 12)));
            //clients.Add(new Client_model("Мария", "Лебедева", "Ивановна", "alt175@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Никита", "Суповкин", "Иванович", "alt176@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Елисеева", "Ивановна", "alt177@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Васнецов", "Иванович", "alt178@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Выхина", "Иванович", "alt179@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Денис", "Пурованов", "Иванович", "alt180@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Искандеров", "Иванович", "alt181@mail.ru", new DateTime(2001, 04, 12)));

            //clients.Add(new Client_model("Альберт", "Соловеев", "Иванович", "alt182@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Алошин", "Иванович", "alt183@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Афанасий", "Поняев", "Иванович", "alt184@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Самуин", "Иванович", "alt185@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Мусин", "Иванович", "alt186@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Буковав", "Иванович", "alt187@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Нянин", "Иванович", "alt188@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Лилин", "Иванович", "alt189@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Коровина", "Ивановна", "alt190@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Елена", "Ранина", "Ивановна", "alt191@mail.ru", new DateTime(2003, 04, 12)));
            //clients.Add(new Client_model("Анастасия", "Тытоева", "Ивановна", "alt192@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Лариса", "Панакина", "Ивановна", "alt193@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Юлия", "Локаева", "Ивановна", "alt194@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Валентина", "Тутуева", "Ивановна", "alt195@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Галина", "Локтева", "Ивановна", "alt196@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Пусина", "Ивановна", "alt197@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Шамаева", "Ивановна", "alt198@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Семен", "Сорин", "Иванович", "alt199@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Росина", "Ивановна", "alt200@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Гоголь", "Иванович", "alt201@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Петров", "Иванович", "alt202@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Петрова", "Ивановна", "alt203@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Макушев", "Иванович", "alt204@mail.ru", new DateTime(2005, 04, 12)));
            //clients.Add(new Client_model("Мария", "Лузина", "Ивановна", "alt205@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Никита", "Соснин", "Иванович", "alt206@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Еремеева", "Ивановна", "alt207@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Вовин", "Иванович", "alt208@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Власов", "Иванович", "alt209@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Денис", "Пухтин", "Иванович", "alt210@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Исумов", "Иванович", "alt211@mail.ru", new DateTime(2001, 04, 12)));

            //clients.Add(new Client_model("Альберт", "Солнцев", "Иванович", "alt212@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Апин", "Иванович", "alt213@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Афанасий", "Полкин", "Иванович", "alt214@mail.ru", new DateTime(2005, 04, 12)));
            //clients.Add(new Client_model("Николай", "Сукиров", "Иванович", "alt215@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Мулин", "Иванович", "alt216@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Бусин", "Иванович", "alt217@mail.ru", new DateTime(2004, 04, 12)));
            //clients.Add(new Client_model("Семен", "Ноков", "Иванович", "alt218@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Лодин", "Иванович", "alt219@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Конина", "Ивановна", "alt220@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Елена", "Румина", "Ивановна", "alt221@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Анастасия", "Тонова", "Ивановна", "alt222@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Лариса", "Поснина", "Ивановна", "alt223@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Юлия", "Лорина", "Ивановна", "alt224@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Валентина", "Тынина", "Ивановна", "alt225@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Галина", "Лупина", "Ивановна", "alt226@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Пакина", "Ивановна", "alt227@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Шомова", "Ивановна", "alt228@mail.ru", new DateTime(2000, 04, 12)));
            //clients.Add(new Client_model("Семен", "Сотов", "Иванович", "alt229@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Дарья", "Рокина", "Ивановна", "alt230@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Борис", "Голон", "Иванович", "alt231@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Петр", "Перин", "Иванович", "alt232@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Петина", "Ивановна", "alt233@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Станислав", "Машин", "Иванович", "alt234@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Мария", "Лукина", "Ивановна", "alt235@mail.ru", new DateTime(2003, 04, 12)));
            //clients.Add(new Client_model("Никита", "Собин", "Иванович", "alt236@mail.ru", new DateTime(2002, 04, 12)));
            //clients.Add(new Client_model("Надежда", "Енева", "Ивановна", "alt237@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Николай", "Вокин", "Иванович", "alt238@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Иван", "Варом", "Иванович", "alt239@mail.ru", new DateTime(2001, 04, 12)));
            //clients.Add(new Client_model("Денис", "Пупин", "Иванович", "alt240@mail.ru", new DateTime(2001, 04, 12)));

            //foreach (var item in clients)
            //    Date_Layer_model.Client.Insert(item);

            //5
        }
    }
}
