using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Design Pattern - Builder - Computer set example
namespace Design_Patterns_Implementation
{
    class PCConfiguration
    {
        private String desktop;
        private String processor;
        private String graphics;
        private String ram;
        private String hdd;

        public void setDesktop(String desktop)
        {
            this.desktop = desktop;
        }
        public void setProcessor(String processor)
        {
            this.processor = processor;
        }
        public void setGraphics(String graphics)
        {
            this.graphics = graphics;
        }
        public void setRam(String ram)
        {
            this.ram = ram;
        }
        public void setHdd(String hdd)
        {
            this.hdd = hdd;
        }
        public void show()
        {
            if (desktop != null)
                Console.WriteLine("Desktop: " + this.desktop);
            if (processor != null)
                Console.WriteLine("Processor: " + this.processor);
            if (graphics != null)
                Console.WriteLine("Graphics: " + this.graphics);
            if (ram != null)
                Console.WriteLine("Ram: " + this.ram);
            if (hdd != null)
                Console.WriteLine("Hdd: " + this.hdd);
        }
    }
    abstract class Builder
    {
        protected PCConfiguration computerSet;
        public void newSet()
        {
            computerSet = new PCConfiguration();
        }
        public PCConfiguration getSet()
        {
            return computerSet;
        }

        public abstract void buildDesktop();
        public abstract void buildProcessor();
        public abstract void buildGraphics();
        public abstract void buildRam();
        public abstract void buildHdd();
    }
    class PCSet1 : Builder
    {
        public override void buildDesktop()
        {
            computerSet.setDesktop("Benq 19");
        }
        public override void buildProcessor()
        {
            computerSet.setProcessor("AMD");
        }
        public override void buildGraphics()
        {
            computerSet.setGraphics("ATI");
        }
        public override void buildRam()
        {
            computerSet.setRam("DDR3");
        }
        public override void buildHdd()
        {
            computerSet.setHdd("Samsung");
        }
    }
    class PCSet2 : Builder
    {
        public override void buildDesktop()
        {
            computerSet.setDesktop("LG");
        }
        public override void buildProcessor()
        {
            computerSet.setProcessor("Intel");
        }
        public override void buildGraphics()
        {
            computerSet.setGraphics("Nvidia");
        }
        public override void buildRam()
        {
            computerSet.setRam("DDR4");
        }
        public override void buildHdd()
        {
            int t = new int();
            while (true)
            {
                Console.WriteLine("Choose HDD: (1) Samsung, (2) Segate, (3) Caviar");
                bool parsing = int.TryParse(Console.ReadLine(), out t);
                if (t > 0 && t < 4)
                    break;
                
            }
            switch (t)
            {
                case 1:
                    computerSet.setHdd("Samsung");
                    break;
                case 2:
                    computerSet.setHdd("Segate");
                    break;
                case 3:
                    computerSet.setHdd("Caviar");
                    break;
                default:
                    Console.WriteLine("You have chosen incorrectly!");
                    break;
            }
        }
    }
    class Director
    {
        private Builder builder;
        public void setBuilder(Builder builder)
        {
            this.builder = builder;
        }
        public PCConfiguration getPCSet()
        {
            return builder.getSet();
        }
        public void Build()
        {
            builder.newSet();
            builder.buildDesktop();
            builder.buildProcessor();
            builder.buildHdd();
            builder.buildRam();
            builder.buildGraphics();
        }
    }

}