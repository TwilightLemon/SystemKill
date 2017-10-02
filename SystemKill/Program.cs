using System;
using System.Diagnostics;

namespace SystemKill
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            foreach (var p in Process.GetProcesses())
            {
                try
                {
                    if (p.ProcessName != "SystemKill")
                    { p.Kill(); Console.WriteLine("[" + i + "]" + p.ProcessName); }
                }
                catch { }
                i++;
            }
            Console.ReadLine();
        }
    }
}
