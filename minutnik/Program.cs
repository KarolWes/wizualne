using System;
using System.Diagnostics.CodeAnalysis;


namespace wizualne
{
    
    class Demo
    {

        public static int Sum(params int[] args)
        {
            int res = 0;
            foreach (var num in args)
            {
                res += num;
            }

            return res;
        }

        public static int SumAvg(out float avg, params int[] args)
        {
            int res = 0;
            foreach (var num in args)
            {
                res += num;
            }

            avg = res / args.Length;
            return res;
        }
        
        static int Main(String[] args)
        {
            Minutnik m = new Minutnik(10, 40, 30);
            m.show();
            int[] tab = new int[(int)1e6];
            var start = DateTime.Now;
            for (int i = 0; i < (int)1e6; i++)
            {
                tab[i] = 1;
            }
            var res = tab.Sum();
            var diff = DateTime.Now - start;
            Console.WriteLine(res);
            Console.WriteLine("Czas: {0}", diff);

            object[] tab2 = new object[(int)1e6];
            start = DateTime.Now;
            for (int i = 0; i < (int)1e6; i++)
            {
                tab2[i] = 1;
            }

            res = tab2.Sum(o => (int)o);
            diff = DateTime.Now - start;
            Console.WriteLine(res);
            Console.WriteLine("Czas: {0}", diff);
            
            Console.WriteLine(Sum(1,2,3));
            float avg = 0.0f;
            Console.WriteLine(SumAvg(out avg,2,3,4));
            Console.WriteLine(avg);
            
            return 0;
        }
    }
}

