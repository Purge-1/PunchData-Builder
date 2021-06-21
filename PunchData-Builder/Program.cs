using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace PunchData_Builder
{
    class Program
    {
        public static void Main()
        {
            Console.Title = "Growtopia - PunchData Builder";
            Console.Clear();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                          Growtopia");
            Console.WriteLine("                       PunchData Builder");
            Console.WriteLine("                      By purge_dev");
            Console.WriteLine($"__________________________{DateTime.Now.ToString("d/MM/yyyy/h/m")}__________________________");
            PunchData data = new PunchData();
            data.AddEffectToList();
            data.Build();
            Console.WriteLine("Press any key to close..."); 
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
