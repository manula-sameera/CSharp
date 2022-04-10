using System;

namespace ns1
{
    using ns2;
    class point
    {
        void show()
        {
            Console.WriteLine("This is namespace 1");
        }
        static void Main()
        {
            ns1.point p = new ns1.point();
            p.show();
            ns2.point2 q = new ns2.point2();
            q.show2();
        }
    }
}

namespace ns2
{


    class point2
    {

        //private string name;

         internal void show2()
        {
            Console.WriteLine("This is namespace 2");
        }
    }
}