using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Client_model
    {
        //public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Middle_name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public Client_model(/*int _id, */string _first_name, string _last_name, string _middle_name, string _email, DateTime _birthday)
        {
            //Id = _id;
            First_name = _first_name;
            Last_name = _last_name;
            Middle_name = _middle_name;
            Email = _email;
            Birthday = _birthday;
        }
        public override string ToString()
        {
            return $"{Last_name,15} {First_name,15} {Middle_name,15} {Email,15} {Birthday, 10}";
        }
    }
}

