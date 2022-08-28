using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Engine : IButton
    {
        public void printDetais()
        {
            Console.WriteLine("Engine is Start");
        }
    }
}
