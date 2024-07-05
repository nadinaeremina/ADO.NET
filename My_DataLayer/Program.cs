using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient; //наш провайдер живет здесь
using My_DataLayer.Data_Layer_folder;
using My_DataLayer.Models_folder;

namespace My_DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // DataLayer-когда база готова

            // TeacherById
            // создаем обьект 'TeacherModel'
            TeacherModel t_mod1 = Data_Layer.Teacher.TeacherById(14);
            Console.WriteLine(t_mod1);

            Console.WriteLine("-------------------------------------------------");

            TeacherModel t_mod2 = Data_Layer.Teacher.TeacherById(12);
            Console.WriteLine(t_mod2);

            Console.WriteLine("-------------------------------------------------");

            // Teacher_All
            List<TeacherModel> t_mod_collections = Data_Layer.Teacher.TeachersAll();

            foreach (var item in t_mod_collections)
                Console.WriteLine(item);

            Console.WriteLine("-------------------------------------------------");

            // Teacher_add
            int id = Data_Layer.Teacher.Insert(new TeacherModel(0, "FN_new_1", "LN_new_1", 1000, 100, DateTime.Now));
            Console.WriteLine(id);

            Console.WriteLine("-------------------------------------------------");

            // Delete
            int id_2 = Int32.Parse(Console.ReadLine());

            if (Data_Layer.Teacher.Delete(id_2))
                Console.WriteLine($"teacher {id_2} delete");
            else
                Console.WriteLine($"teacher {id_2} not delete");
        }
    }
}
