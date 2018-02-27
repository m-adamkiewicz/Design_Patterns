using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation
{
    abstract class Car
    {
        protected string car = "Business Car";
        public virtual String about()
        {
            return car;
        }
        public abstract double price();
    }
    abstract class Decorator : Car
    {
        public abstract override String about();
    }
    class Mercedes : Car
    {
        public Mercedes()
        {
            car = "Mercedes";
        }
        public override double price()
        {
            return 100000;
        }
    }
    class Fiat : Car
    {
        public Fiat()
        {
            car = "Fiat";
        }
        public override double price()
        {
            return 10000;
        }
    }
    class AirConditioning : Decorator
    {
        Car car;
        public AirConditioning(Car car)
        {
            this.car = car;
        }
        public override String about()
        {
            return car.about() + " + AirConditioning";
        }
        public override double price()
        {
            if (car is Mercedes)
                return car.price() + 10000;
            else if (car is Fiat)
                return car.price() + 5000;
            return 0;
        }
    }
    class WinterTyres : Decorator
    {
        Car car;
        public WinterTyres(Car car)
        {
            this.car = car;
        }
        public override string about()
        {
            return car.about() + " + Winter Tyres";
        }
        public override double price()
        {
            return car.price() + 1000;
        }
    }
}
