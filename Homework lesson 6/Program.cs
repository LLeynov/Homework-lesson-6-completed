using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;




namespace Homework_lesson_6
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            var procList = Process.GetProcesses();
            foreach (var proc in procList)
            {
                Console.WriteLine($"{proc.Id} {proc.ProcessName} {proc.BasePriority}");
            }
            Console.Write("name = ");
            var name = Console.ReadLine();
            try
            {
                procList.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                Console.WriteLine($"{name} deleted!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Process {name} not found!");
            }


        }
    }
}
