using System;
namespace Polymorphism_2673
{
    public class Canon : PrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension: 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}