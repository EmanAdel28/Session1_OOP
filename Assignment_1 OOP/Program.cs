using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Security.Claims;

namespace Assignment_1_OOP
{

    enum Gender
    {
        Male , Female
    }

    enum Days
    {
          Saturday, Sunday, Monday , Tuesday , Wednesday, Thursday, Friday
    }

    [Flags]
    enum Permissions : byte
    {
        Delete = 1, Execute = 2, Read = 4, write = 8

    }

    public struct Point
    {
        public int x;
        public int y;

        public Point(int _x , int _y)
        {
            x = _x;
            y = _y;
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int num)
        {
            x = y = num;
           
        }
    }
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

            #region Enum 

            //Employee employee = new Employee();
            //employee.genger = Gender.Male;

            //Days days = Days.Friday;
            //Days days = (Days)2;

            //Enum.TryParse<Days>(Console.ReadLine(), true, out Days  day);


            #endregion

            #region Permission

            Permissions permissions = new Permissions();

            // Add Permision
            permissions = permissions | Permissions.Delete;
            permissions = permissions | Permissions.Read;
            permissions = permissions | Permissions.Execute;

            Console.WriteLine(permissions);

            // Delete 
            if ((permissions & Permissions.Execute) == Permissions.Execute)
            {
                // if exist it will delete
                permissions = permissions ^ Permissions.Execute;

            }
            else
            {
                // if not exist => does not make action 
                permissions = permissions;


            }
            #endregion

            #region Strucrt

            //What You Can Write Inside The Struct Or Class
            //1.Attributes[Fields] => Member Variable
            //2.Functions[Constructor, Getter Setter, Method]
            //3.Properties[Full Property, Automatic Property, Indexer]
            //4.Events


            //Access Modifier Allowed Inside Struct?
            //Private[Default]    Internal       Public

            //Point p01 = new Point();

            //Console.WriteLine(p01.x);
            //Console.WriteLine(p01.y);

            //Point p01 = new Point(2,7);

            //Console.WriteLine(p01.x);
            //Console.WriteLine(p01.y);

            Point p01 = new Point(2);

            Console.WriteLine(p01.x);
            Console.WriteLine(p01.y);

            #endregion

        }
    }
}
