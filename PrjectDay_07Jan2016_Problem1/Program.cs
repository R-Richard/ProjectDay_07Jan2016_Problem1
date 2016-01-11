using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjectDay_07Jan2016_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note: Two Versions included below -- Program 1: Reads from static values; Program 2 (below Program 1) reads and assigns values from Console

            //Program 1: set values
            string compNameAsString = "XYZ Company";
            string propertyNumberAsString = "1234";
            int propertyNumberAsInt = Convert.ToInt32(propertyNumberAsString);
            string streetAndDesigAsString = "Commerce Drive";
            string ZipAsString = "44110";
            int ZipAsInt = Convert.ToInt32(ZipAsString);
            string cityAsString = "Cleveland";
            string stateAsString = "Ohio";
            string webAddressAsString = "www.xyz.com";
            string PhoneNbrAsString = "(216) 123-9876";
            string FaxNbrAsString = "(216) 987-1234";
            string ManagerFirstNameAsString = "Andi";
            string ManagerSurnameAsString = "Public";
            string ManagerPhoneAsString = "(216) 789-4321";

            Console.WriteLine(compNameAsString);
            Console.WriteLine(propertyNumberAsString + " " + streetAndDesigAsString);
            Console.WriteLine(cityAsString + ", " + stateAsString + ", " + ZipAsString);
            Console.WriteLine("Phone: " + PhoneNbrAsString);
            Console.WriteLine("Fax: " + FaxNbrAsString);
            Console.WriteLine("Web: " + webAddressAsString);
            Console.WriteLine(" ");
            Console.WriteLine("Manager: " + ManagerFirstNameAsString + " " + ManagerSurnameAsString);
            Console.WriteLine("Phone: " + ManagerPhoneAsString);

            //Note: Program 2 - Read from Console

            /*Console.WriteLine("Enter Company Name: ");
             string compNameAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Enter Property Number:");
             string propertyNumberAsString = Console.ReadLine();
             int propertyNumberAsInt = Convert.ToInt32(propertyNumberAsString);
             Console.Clear();

             Console.WriteLine("Enter Street And Designator");
             string streetAndDesigAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Enter Zip");
             string ZipAsString = Console.ReadLine();
             int ZipAsInt = Convert.ToInt32(ZipAsString);
             Console.Clear();

             Console.WriteLine("Enter City:");
             string cityAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Enter State:");
             string stateAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Enter web address:");
             string webAddressAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Enter Phone Nbr:");
             string PhoneNbrAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Enter Fax Nbr:");
             string FaxNbrAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Enter Manager First Name:");
             string ManagerFirstNameAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Enter Manager Surname:");
             string ManagerSurnameAsString = Console.ReadLine();
             Console.Clear();


             Console.WriteLine("Enter Manager Phone Number:");
             string ManagerPhoneAsString = Console.ReadLine();
             Console.Clear();

             Console.WriteLine("Company Name: " + compNameAsString);
             Console.WriteLine(propertyNumberAsString + " " + streetAndDesigAsString);
             Console.WriteLine(cityAsString + ", " + stateAsString + ", " + ZipAsString);
             Console.WriteLine("Phone: " + PhoneNbrAsString);
             Console.WriteLine("Fax: " + FaxNbrAsString);
             Console.WriteLine("Web: " + webAddressAsString);
             Console.WriteLine(" ");
             Console.WriteLine("Manager: " + ManagerFirstNameAsString + " " + ManagerSurnameAsString);
             Console.WriteLine("Phone: " + ManagerPhoneAsString);*/

            //Console.WriteLine()
            //Console.WriteLine(Enter Fax Number:);
            //string faxNbrAsString = Console.ReadLine();







        }
    }
}
