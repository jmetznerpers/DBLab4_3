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
            return $"Company: {aCompany} Customer Name: {aContactName} \tEmail:{aContactEmail} \tPhone Number: {aPhone}";
        }

    }
        
    class Program
    {
        static bool 
            Continue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to go again? (y/n)");
                string response = Console.ReadLine();
                response = response.ToLower();
                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }
        }

        static void ShowCustomers(List<Customer> customers)
        {
            foreach (Customer next in customers)
            {
                Console.WriteLine(next);
            }
        }
        static Customer SearchCustomers(List<Customer> customers, string cCompany)
         {
             foreach (Customer next in customers)
             {
                 if (next.GetCompany() == cCompany)
                 {
                     return next;
                 }
             }
            Console.WriteLine("That Customer Doesn't Exist!");
            return null;
         }
        static Customer SearchCustomersByName(List<Customer> customers, string cName)
        {
            foreach (Customer next in customers)
            {
                if (next.GetContactName() == cName)
                {
                    return next;
                }
            }
            Console.WriteLine("That Customer Doesn't Exist!");
            return null;
            
        }
        static Customer SearchCustomersByPhone(List<Customer> customers, string cPhone)
        {
            foreach (Customer next in customers)
            {
                if (next.GetPhone() == cPhone)
                {
                    return next;
                }
            }
            Console.WriteLine("That Customer Doesn't Exist!");
            return null;

        }

        
        


        public static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();

            Customer c1 = new Customer("MGM", "James Bond", "licensedtokill@MGM.com", "313-007-2663");
            customers.Add(c1);
            Customer c2 = new Customer("FOX", "Ellen Ripley", "aliensmasher@fox.com", "313-887-9812");
            customers.Add(c2);
            Customer c3 = new Customer("DISNEY", "Mickey Mouse", "themouse@disney.com", "313-887-0340");
            customers.Add(c3);
            Customer c4 = new Customer("BLUMHOUSE", "Quentin Tarantino", "rdog23@blumhouse.com", "313-111-2222");
            customers.Add(c4);
            Customer c5 = new Customer("USA", "Joe Biden", "pres@whitehouse.gov", "313-000-0000");
            customers.Add(c5);

            Console.WriteLine("Writing specific customer");
            Console.WriteLine(c1);
            //Console.WriteLine("Adding new customer!");
            Customer newCustomer = new Customer("Rocket", "Jeff Metzner", "jeffmetzner@rocket.com", "313-867-5309");
            customers.Add(newCustomer);
            Console.WriteLine();

            do
            {
                Console.WriteLine("Showing all customers!");
                ShowCustomers(customers);
                Console.WriteLine();
                SearchChoice();


                /*
                ShowCustomers(customers);
                Console.WriteLine("Searching customer by company name!");
                Console.WriteLine();
                Console.WriteLine(SearchCustomers(customers, "Blumhouse"));
                Console.WriteLine();
                Console.WriteLine("What customer would you like to search for?  Please enter their name: ");
                string newSearch = Console.ReadLine();
                Console.WriteLine(SearchCustomersByName(customers, newSearch));
                Console.WriteLine();
                Console.WriteLine("What customer would you like to search for?  Please enter their Phone Number using this format xxx-xxx-xxxx: ");
                string newSearch2 = Console.ReadLine();
                Console.WriteLine(SearchCustomersByPhone(customers, newSearch2));
                Console.WriteLine();
                */

                void SearchChoice() //allows searching by name company name and phone, no format updating for phone or for names (they are case sensative)
                {
                    Console.WriteLine("Would you like to search by Name, Company Name, or Phone Number? N/CN/P");
                    string response = Console.ReadLine();
                    response.ToLower();
                    if (response == "n")
                    {
                        Console.WriteLine("What customer would you like to search for?  Please enter their name: ");                       
                        string newSearch = Console.ReadLine();
                        //newSearch.Equals(newSearch, StringComparison.OrdinalIgnoreCase);
                        Console.WriteLine(SearchCustomersByName(customers, newSearch));
                        Console.WriteLine();
                    }
                    else if (response == "cn")
                    {
                        Console.WriteLine("What customer would you like to search for?  Please enter their company Name:");
                        string newSearch = Console.ReadLine();
                        Console.WriteLine(SearchCustomers(customers, newSearch));
                        Console.WriteLine();
                    }
                    else if (response == "p")
                    {
                        Console.WriteLine("What customer would you like to search for?  Please enter their Phone Number using this format xxx-xxx-xxxx: ");
                        string newSearch = Console.ReadLine();
                        Console.WriteLine(SearchCustomersByPhone(customers, newSearch));
                        Console.WriteLine();
                    }
                }
            }
            while (Continue());





        }


        
    }
}
