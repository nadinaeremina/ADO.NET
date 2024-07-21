using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyAsync
{
    internal class Program
    {
        // 1 //    static void Main(string[] args)
        //    {
        // одну ф-цию мы запустили - она рабатывает, вторую не сможем запустить, пока первая не отработает
        // 'Async' позволяет нам не дожидаясь пока закончит работу первая ф-ция - запустить вторую

        // блокируем внешний поток, выполняем внутри какие-то ф-ции, рез-т возвращаем на внешний поток и работаем дальше
        // все тяжелые функциональности отправляем на параллельный поток, серьезная обработка на внутреннем потоке, 
        // а легкие на внешнем потоке - многопоточность, можно выиграть в скорости, обработка будет быстрее происходить

        // асинхронность - это отсутствие блокировки

        // 2 способа:

        // 1 // использование классического паттерна
        // 'Begin***()' - начинаем какое-то действие, 'End***()' - завершаем какое-то действие
        // Также называют: 'BeginAction()', 'EndAction()' 
        // 'return' только после 'EndAction()' 
        // Если вызвать 'EndAction()' до того, как действие в доп. потоке завершится - то этот вызов станет блокирующим
        // те он заблокирует вызывающий его поток // Сначала 'BeginAction()' - потом 'EndAction()'
        // нужно узнать, когда действие завершилось и если оно завершилось - вызвать 'EndAction()'

        // 1.1 'callback delegate' - тип возвращаемого значения - 'IAsyncResult'
        // 1.2 'class WaitHandle' -  2 метода: 'IAsyncResult.AsyncWaitHandle', 'IAsyncResult.AsyncState'
        // 1.3 - мониторинг дополнительного потока


        // 2 // более современный подход
        // 'async', 'await'


        /////////////////////////////// 1 'callback delegate'///////////////////////////////

        //// для того, чтобы вызвалась наша форма 
        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new Form1());

        //}

        /////////////////////////////// 2 ///////////////////////////////////////////////


        /// <summary>

        /// Главная точка входа для приложения.

        /// </summary>

        [STAThread]

        static string Show_func_1(string file)
        {
            Thread.Sleep(4000); //read file
            return $" File  {file}  is read";
        }

        // class Task - позволяет вставить в очередь на вып-ие 'ThreadPool' (очередь вып-ия задач)
        static Task<string> Show_func_1_Async(string file) //ThreadPool
        {
            return Task.Run<string>(() =>
            {
                //// 1 вариант
                //Thread.Sleep(4000); //read file
                //return $" File   {file}  is read";
                //// 2 вариант
                return Show_func_1(file);
            });
        }

        async static Task Call_Show_func_1_Async()
        {
            string res1 = await Show_func_1_Async("1.txt");
            string res2 = await Show_func_1_Async("2.txt");
            string res3 = await Show_func_1_Async("3.txt");

            // action - здесь чтото делаем с файлами прочитанными

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
        }

        async static Task Main(string[] args)// Main должен быть типа 'Task'
        {
            await Call_Show_func_1_Async();
            Console.ReadKey();
        }
    }
}
