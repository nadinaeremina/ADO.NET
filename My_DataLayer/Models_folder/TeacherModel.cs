using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace My_DataLayer.Models_folder
{
    public class TeacherModel
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public decimal Salary { get; private set; }
        public decimal Premium { get; private set; }
        public DateTime ED { get; private set; }

        public TeacherModel(int _id, string firstName, string lastName, decimal salary)
        {
            ID = _id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public TeacherModel(int _id, string firstName, string lastName, decimal salary, decimal premium, DateTime ed)
        {
            ID = _id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Premium = premium;
            ED = ed;
        }
        public override string ToString()
        {
            return $"{ID,5} {LastName,15} {FirstName,15} {Salary,10} ";
        }
    }
}
