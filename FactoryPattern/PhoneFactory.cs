using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioFactoryPattern.Interfaces;
using DesafioFactoryPattern.Model;

namespace DesafioFactoryPattern.FactoryPattern
{
    class PhoneFactory
    {
        public IPhone GetPhone(string brand)
        {
            if (brand == "APPLE") return new Apple();
            else if (brand == "LG") return new LG();
            else if (brand == "MOTOROLA") return new Motorola();
            else if (brand == "SAMSUNG") return new Samsung();
            return null;
        }
    }
}
