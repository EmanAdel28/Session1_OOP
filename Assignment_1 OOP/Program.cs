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
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.


            //Console.WriteLine("Days Of The Week\n");

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}


            #endregion

            #region Q2
            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //bool Flags;
            //Season season;
            //do
            //{
            //    Console.WriteLine("Enter the season");
            //    Flags = Enum.TryParse<Season>(Console.ReadLine(), true, out season);

            //} while (!Flags);

            //switch (season)
            //{
            // case Season.Spring:
            //        Console.WriteLine("spring: march to may ");
            //        break;

            // case Season.Summer:
            //        Console.WriteLine("summer: june to august");
            //        break;

            // case Season.Autumn:
            //        Console.WriteLine("autumn: September to November");
            //        break;

            // case Season.Winter:
            //        Console.WriteLine("winter: December to February");
            //        break;

            //}

            #endregion

            #region Q3
            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable

            Permissions permissions = new Permissions();

            // Add Permision
            permissions= permissions | Permissions.Delete;
            permissions = permissions | Permissions.Read;
            permissions = permissions | Permissions.Execute;

            Console.WriteLine(permissions);

            // Delete 
            if((permissions & Permissions.Execute) ==  Permissions.Execute)
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



            #endregion
        }
    }
}
