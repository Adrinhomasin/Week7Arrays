using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab hommikusöögi menüü
            //programm palub kasutajal teha valiku
            //programm kuvab kasutaja valikut konsoolis

            string[] menu = { "omlett", "pannkoogid", "keedumuna", "neljavilja puder", "singivõileib" };
            Console.WriteLine($"meie menüüs on {menu.Length} valikut.");
            //menu[4] = "juustuvõileib";
            //menu[3] = "kaeravilja puder";

            Console.WriteLine("tänases menüüs on:");
            for(int i = 0; i < menu.Length; i++)
            {
                if (menu[i]=="neljavilja puder")
                {
                    menu[i] = "kaerapuder";
                }
                else if (menu[i]=="singivõileib")
                {
                    menu[i] = "juustuvõileib";
                }
                Console.WriteLine(menu[i]);
            }
            Console.WriteLine("tee oma valiku(vali number 1-5:");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            userChoice--;
            Console.WriteLine($"teie valik on {menu[userChoice]}");
            

            /*foreach(string menuElement in menu)
            {
                
                Console.WriteLine(menuElement);
            }*/

        }
    }
}
