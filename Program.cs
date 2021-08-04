using System;
using System.Collections.Generic;

namespace DBWeek4Lab4_3
{
    class Customer
    {
        private string aCompany;
        private string aContactName;
        private string aContactEmail;
        private string aPhone;

        public Customer(string bCompany, string bContactName, string bContactEmail, string bPhone)
        {
            SetCompany(bCompany);
            SetContactName(bContactName);
            SetContactEmail(bContactEmail);
            SetPhone(bPhone);
        }
        public string GetCompany()
        {
            return aCompany;
        }
        public void SetCompany(string bCompany)
        {
            aCompany = bCompany;
        }
        public string GetContactName()
        {
            return aContactName;
        }
        public void SetContactName(string bContactName)
        {
            aContactName = bContactName;
        }
        public string GetContactEmail()
        {
            return aContactEmail;
        }
        public void SetContactEmail(string bContactEmail)
        {
            aContactEmail = bContactEmail;
        }
        public string GetPhone()
        {
            return aPhone;
        }
        public void SetPhone(string bPhone)
        {
            aPhone = bPhone;
        }


        public override string ToString()
        {
            return $"Company: {aCompany} Customer Name: {aContactName} Email:{aContactEmail} Phone Number: {aPhone}";
        }

    }
        
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();

            Customer c1 = new Customer("MGM", "James Bond", "licensedtokill@MGM.com", "313-007-2663"); 
            customers.Add(c1);
            Customer c2 = new Customer("Fox", "Ellen Ripley", "aliensmasher@fox.com", "313-887-9812");
            customers.Add(c2);
            Customer c3 = new Customer("Disney", "Mickey Mouse", "themouse@disney.com", "313-887-0340");
            customers.Add(c3);
            Customer c4 = new Customer("Blumhouse", "Quentin Tarantino", "rdog23@blumhouse.com", "313-111-2222");
            customers.Add(c4);
            Customer c5 = new Customer("USA", "Joe Biden", "pres@whitehouse.gov", "313-000-0000");
            customers.Add(c5);


            Console.WriteLine(c1);
        }
    }
}
