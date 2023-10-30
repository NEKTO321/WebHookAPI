using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHookAPI
{
    public class Load
    {
        static void Main()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyLoad += new AssemblyLoadEventHandler(AssemblyLoaded);
        }
        private static void AssemblyLoaded(object sender, AssemblyLoadEventArgs args)
        {
            Console.WriteLine($"Загружаю: {args.LoadedAssembly.GetName().Name.ToUpper()}@{args.LoadedAssembly.GetName().Version}");
        }
    }
}
