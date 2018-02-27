using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Builder Pattern execution
            Console.WriteLine("===========Builder Design Pattern=========");
            Director boss = new Director();
            Builder builder = new PCSet1();
            Builder builder2 = new PCSet2();

            boss.setBuilder(builder);
            boss.Build();
            PCConfiguration set1 = boss.getPCSet();

            boss.setBuilder(builder2);
            boss.Build();
            PCConfiguration set2 = boss.getPCSet();
            Console.WriteLine("Set 1");
            set1.show();
            Console.WriteLine("\nSet 2");
            set2.show();
            Console.WriteLine("==========END OF BUILDER PATTERN==========\n");
            #endregion

            #region Decorator Pattern execution
            Console.WriteLine("==============Decorator Design Pattern==============");
            Car c1 = new Mercedes();
            Car c2 = new Fiat();

            Console.WriteLine("\nCar prices without additional equipment");
            Console.WriteLine(c1.about() + " " + c1.price());
            Console.WriteLine(c2.about() + " " + c2.price());

            Console.WriteLine("\nCar prices with Air Conditioning");
            c1 = new AirConditioning(c1);
            c2 = new AirConditioning(c2);
            Console.WriteLine(c1.about() + " " + c1.price());
            Console.WriteLine(c2.about() + " " + c2.price());

            Console.WriteLine("\nCar prices with winter tyres and air conditioning");
            c1 = new WinterTyres(c1);
            c2 = new WinterTyres(c2);
            Console.WriteLine(c1.about() + " " + c1.price());
            Console.WriteLine(c2.about() + " " + c2.price());

            Console.WriteLine("\nFully equipped car");
            Car c3 = new WinterTyres(new AirConditioning(new Mercedes()));
            Console.WriteLine(c3.about() + " " + c3.price());
            Console.WriteLine("==============End of Decorator Pattern==============");
            #endregion


            Console.ReadKey();
        }
    }
}
