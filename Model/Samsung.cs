using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioFactoryPattern.Interfaces;

namespace DesafioFactoryPattern.Model
{
    class Samsung : IPhone
    {
        public string Hello()
        {
            return "Hello " + this.GetType().Name.ToString() + " user";
        }
    }
}
