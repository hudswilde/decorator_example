using DecoratorExample1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample1
{
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza) : base(pizza)
        { 
        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de queijo";
            return pizza;
        }
    }
}
