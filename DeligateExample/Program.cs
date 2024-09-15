using System;

namespace DelegateExample
{
    public delegate int DelegateEx(int x);

    class DelegateTest
    {
        static int MyNepal(int x)
        {
            return x + x;
        }

        static void Main(string[] args)
        {
            DelegateEx obj = new DelegateEx(MyNepal);

            int res = obj(5);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
