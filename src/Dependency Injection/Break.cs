using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Break:IButton
    {
        public void printDetais()
        {
            Console.WriteLine("Break is starting");
        }

        
    }
}
