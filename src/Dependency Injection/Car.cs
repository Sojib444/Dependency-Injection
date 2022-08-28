using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Car
    {
        private readonly IButton parts;
        private readonly IButton breaak;

        public Car( IButton button,IButton button1)
        {
            parts = button;
            breaak = button1;
        }
        public void print()
        {
            parts.printDetais();
            breaak.printDetais();
        }
    }
}
