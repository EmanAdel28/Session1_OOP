using System.Drawing;

namespace Assignment_1_OOP
{

    enum WeekDays
    {
        Monday=0 , Tuesday=1, Wednesday,Thursday , Friday, Saturday,Sunday
    }

    enum Season
    {
        Spring, Summer, Autumn, Winter
    }

    [Flags]
    enum Permissions : byte
    {
        Delete =1, Execute =2, Read=4 , write=8
        
    }

    enum Colors
    {
        Red, Green, Blue
    }

    
    internal class Program
    {

        public static double CalculateDestance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static void Main(string[] args)
        {
            #region Q1
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.


            //try
            //{
            //    Console.WriteLine("Days Of The Week\n");

            //    for (int i = 0; i < 7; i++)
            //    {
            //        Console.WriteLine((WeekDays)i);
            //    }
            //}
            //catch(Exception ex) {
            //{
            //        Console.WriteLine(ex.Message);

            //    }


            #endregion

            #region Q2
            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //try
            //{
            //    bool Flags;
            //    Season season;
            //    do
            //    {
            //        Console.WriteLine("Enter the season");
            //        Flags = Enum.TryParse<Season>(Console.ReadLine(), true, out season);

            //    } while (!Flags);

            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("spring: march to may ");
            //            break;

            //        case Season.Summer:
            //            Console.WriteLine("summer: june to august");
            //            break;

            //        case Season.Autumn:
            //            Console.WriteLine("autumn: September to November");
            //            break;

            //        case Season.Winter:
            //            Console.WriteLine("winter: December to February");
            //            break;

            //    }
            //} catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region Q3
            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable

            try
            {
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

                Console.WriteLine(permissions);
            }

            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }


            #endregion

            #region Q4
            // Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            // Write a C# program that takes a color name as input from the user and displays a message
            // indicating whether the input color is a primary color or not.

            //try
            //{


            //    Console.Write(" Please Enter Color Name : ");

            //    if (Enum.TryParse(Console.ReadLine(), true, out Colors color))
            //    {

            //        switch (color)
            //        {
            //            case Colors.Red:
            //            case Colors.Green:
            //            case Colors.Blue:
            //                Console.WriteLine("Color is a primary color");
            //                break;
            //            default:
            //                Console.WriteLine("Color is not primary color");
            //                break;

            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input Or Color is not primary color Blease Enter Primary Color");

            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}




            #endregion

            #region Q5
            // Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            // Write a C# program that takes two points as input from the user and calculates the distance between them.

            Point P01 = new Point();
            Point P02 = new Point();
            bool Flag;
            do
            {
                Console.WriteLine("Enter Value X1 : ");
                Flag = double.TryParse(Console.ReadLine(), out P01.X);
                Console.WriteLine("Enter Value y1 : ");
                Flag = double.TryParse(Console.ReadLine(), out P01.Y);

                Console.WriteLine("Enter Value X2 : ");
                Flag = double.TryParse(Console.ReadLine(), out P02.X);
                Console.WriteLine("Enter Value y2 : ");
                Flag = double.TryParse(Console.ReadLine(), out P02.Y);

                if (!Flag)
                {
                    Console.WriteLine("Invalid input. Please enter integers only.");
                }

            } while (!Flag);

            
            Console.WriteLine(CalculateDestance(P01, P02));


            #endregion
        }
    }
}
