using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork1
{
    class Program
    {
        static void ShowInfoAboutProcess(Process process)
        {
            WriteLine(process.ProcessName + "\t\t\t" + process.Id + "\t\t\t" + process.BasePriority);            
        }

        static void Main(string[] args)
        {
            var processes = Process.GetProcesses();
            WriteLine("Имя\t\t\tId\t\t\tПриоритет");
            foreach(var process in processes)
            {
                ShowInfoAboutProcess(process);
            }
            WriteLine("\n\nНажмите любую кнопку . . .");
            ReadKey();
        }
    }
}
