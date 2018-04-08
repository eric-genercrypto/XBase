using System;

namespace XBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new BaseX();
            var t = new BaseT();

            // Console.WriteLine(x.ToBaseX(10));
            // Console.WriteLine(x.ToBaseX(459123));
            // Console.WriteLine(x.ToBaseX(63));

            // Console.WriteLine(x.FromBaseX("1Vrd"));
            // Console.WriteLine(x.FromBaseX("A"));
            var baseT = t.ToMilliSeconds();
            Console.WriteLine(baseT);
            var baseX = x.ToBaseXX(baseT);
            Console.WriteLine(baseX);
            Console.WriteLine(x.FromBaseX(baseX));
        }
    }
}
