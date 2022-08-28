using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Propeerty_InjectionCar
    {

        public IButton? MyProperty { get; set; }
        

        public void getProperty()
        {
            MyProperty?.printDetais();
        }
       
    }
}
