using System;
internal class Program
{
    public class Distance
    {
        public int feet, inch;
        public Distance()
        {

        }
        public Distance(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public void display()
        {
            Console.WriteLine($"the final result is : {feet} feet and {inch} inch");
        }
        public static Distance operator +(Distance da, Distance db)
        {
            Distance dc= new Distance();
            dc.feet = da.feet + db.feet;
            dc.inch = da.inch + db.inch;
            while(dc.inch>12)
            {
                dc.feet++;
                dc.inch =dc.inch-12;
            }
            return dc;
        }
        static void Main(string[] args)
        {
            Distance d = new Distance();
            Distance d1 = new Distance(7, 11);
            Distance d2 = new Distance(8, 10);
            d = d1 + d2;
            d.display();
            Console.ReadKey();
        }
    }
}