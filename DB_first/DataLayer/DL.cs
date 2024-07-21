using DB_first.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DB_first.DataLayer
{
    public static class DL
    {
        public static class Customer
        {
            // вызов хранимой процедуры - 'All_customers'
            // вернуть нужно будет кол-цию об-ов
            public static IEnumerable<Customer_model> Customer_All()
            {
                // создаем 'DB' объект, подключаемся к нашему 'Entities'
                using (var db = new Company_DBEntities())
                {
                    List<Customer_model> customers = new List<Customer_model>();

                    // определяем вызов хранимой процедуры из нашего 'db', приводим к типу кол-ции
                    var res = db.stp_CustomerALL().ToList();

                    foreach (var customer in res)
                    {
                        Customer_model tmp = new Customer_model();

                        tmp.id = customer.id;
                        tmp.FirstName = customer.FirstName;
                        tmp.LastName = customer.LastName;
                        tmp.DateOfBirth = customer.DateOfBirth;

                        customers.Add(tmp);
                    }
                    return customers;
                }
            }

            public static Customer_model ByID(int id)
            {
                using (var db = new Company_DBEntities())
                {
                    Customer_model customer = new Customer_model();

                    var result = db.stp_CustomerByID(id).First();

                    customer.id = result.id;
                    customer.FirstName = result.FirstName;
                    customer.LastName = result.LastName;
                    customer.DateOfBirth = result.DateOfBirth;

                    return customer;
                }
            }
        }
    }
}
