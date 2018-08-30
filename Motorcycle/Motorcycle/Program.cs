using System;

namespace Motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle tester = new Motorcycle(true, "kawaski");

            tester.ShiftGearUp();
            tester.ShiftGearUp();
            tester.shiftgearsDown(1);
            tester.ShiftGearUp();
            tester.ShiftGearUp();
            tester.ShiftGearUp();
            Console.WriteLine(tester.ToString());
        }
    }
}
