namespace Assignment_1_OOP
{

    enum WeekDays
    {
        Monday=0 , Tuesday=1, Wednesday,Thursday , Friday, Saturday,Sunday
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.


            Console.WriteLine("Days Of The Week\n");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((WeekDays)i);
            }
            Console.WriteLine();
           
            #endregion
        }
    }
}
