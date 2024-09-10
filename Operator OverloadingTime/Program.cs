using System;
namespace Operator_OverloadingTime
{
    internal class Program
    {
        public class Datetim
        {
            public int hour, minute, second;

            public Datetim()
            {
            }

            public Datetim(int hour, int minute, int second)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }

            public void display()
            {
                Console.WriteLine($"The final time is: {hour} hour(s), {minute} minute(s), and {second} second(s)");
            }


            public static Datetim operator -(Datetim da, Datetim db)
            {
                Datetim dc = new Datetim();
                dc.second = da.second - db.second;
                dc.minute = da.minute - db.minute;
                dc.hour = da.hour - db.hour;

                if (dc.second < 0)
                {
                    dc.second += 60;
                    dc.minute -= 1;
                }

                if (dc.minute < 0)
                {
                    dc.minute += 60;
                    dc.hour -= 1;
                }

                return dc;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine ("enter first time:");
            int h1= int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second time:");
            int h2 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            Datetim d1 = new Datetim(h1,m1,s1);
            Datetim d2 = new Datetim(h2,m2,s2);

            Datetim d = d1-d2;
            d.display();

            Console.ReadKey();
        }
    }
}
