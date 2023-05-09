using DecoratorExample1.Interface;

namespace DecoratorExample1
{
    //base decorator
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;
        
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string BuscarTipoPizza()
        {
           var pizza = _pizza.BuscarTipoPizza();
            return pizza;
        }
    }
}
