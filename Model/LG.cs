using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFactoryPattern.Model
{
    class LG : Interfaces.IPhone
    {
        public string Hello()
        {
            return "Hello " + this.GetType().Name.ToString() + " user";
        }
    }
}
