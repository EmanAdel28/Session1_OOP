using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Security.Claims;

namespace Assignment_1_OOP
{
    internal class Program
    {

        public static void DoSomeCode()
        {
           try
            {
                int x, y, z;
                x = int.Parse(Console.ReadLine()); //FormatExciption
                y = int.Parse(Console.ReadLine()); 

                z = x / y; //DividedByZeroExciption
                Console.WriteLine(z);

                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100; //IndexOutOfRangeExciption
            }
            // CLR Create Object From Exception
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Log in file
                // Store DB
            }
        }

        public static void DoSomeProtectiveCode()
        {
            bool Flag;
            do
            {
                Flag = int.TryParse(Console.ReadLine(), out int x);

            }while (!Flag);

            int y;
            do
            {
                Flag = int.TryParse(Console.ReadLine(), out  y);

            } while (!Flag || y == 0);

            int[]Numbers = { 1, 2, 3 };

            if(Numbers?.Length > 10)
            {
                Numbers[10] = 100;
            }
        }
        static void Main(string[] args)
        {
            #region Exception Handling 
            // Exciption
            //1. SystemException
            //1.1 FormatExciption
            //1.2 Index out of Range Exciption
            //1.3 Null Reference Exciption 
            //1.4 Invalid Operation Exciption
            //1.5 Arithimetic Exciption 
            //1.5.1 Divided By Zero Exciption
            //1.5.2 OverFlow Exciption 
            //2. ApplicationException



            //Befor Handling Exciption

            //DoSomeCode();

            //After Handling Exciption

            try
            {
                DoSomeProtectiveCode();
                throw new Exception();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                // Close - Free - Delete - Dealocate Unmaged Resource
                // Open File
                // Open Connection Database
                Console.WriteLine("Finally");
            }
            Console.WriteLine("Afer Try - Catch");




            #endregion

            #region Access Modifier
            //Access Modifier Allowed Inside Namespace ?
            //1.Internal[Default]
            //2.Public

            //What You Can Write Inside Namespace ?
            // 1.Class   2.Struct   3.Interface    4.Enum


            //What You Can Write Inside The Struct Or Class
            //1.Attributes[Fields] => Member Variable
            //2.Functions[Constructor, Getter Setter, Method]
            //3.Properties[Full Property, Automatic Property, Indexer]
            //4.Events


            //Access Modifier Allowed Inside Class?
             //Private[Default]    Private Protected    Protected    Internal    Protected Internal   Public




            #endregion

        }
    }
}
