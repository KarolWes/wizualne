using System.Reflection;

namespace wizualne
{
    class Demo
    {
        static int Main(String[] args)
        {
            // OfficeWorker w = new OfficeWorker("Karol", "Wesolowski",
            //     new DateTime(2001, 2, 22)) { Imie = "Antoni"};
            // Console.WriteLine(w);
            //
            // Manager m = new Manager("Jan", "Nowak",
            //     new DateTime(2000, 1, 2));
            // Console.WriteLine(m);
            // Supervisor s = new Supervisor();
            // Console.WriteLine(s);
            //
            //
            // Point p = new Point();
            //
            // Console.WriteLine(p.x);
            //
            // (var Imie, var Nazwisko, var wiek) = ("Jan", "Nowak", 33);
            //
            // Console.WriteLine(Imie);
            //
            // var (Imie2, Nazwisko2, wiek2) = ("Andrzej", "Nowak", 33);
            // Console.WriteLine(Imie2);
            // var pracownik = ("Wojciech", "Nowak", 33);
            // Console.WriteLine(pracownik.Item1);
            // (string Imie, string Nazwisko, int Wiek) prac = ("Adam", "Nowak",
            //     33);
            // Console.WriteLine(prac.Imie);
            
            // Manager men = new Supervisor() { Id = 11};
            // men.Print();
            // ((IPrintable)men).Print();
            // ((IPublicPrintable)men).Print();
            //
            // Office o = new Office();
            // o.ShowAll();
            // foreach (var w in o.GetByPosition("Supervisor"))
            // {
            //     Console.WriteLine(w);
            // }
            // foreach (var w in o.GetByName())
            // {
            //     Console.WriteLine(w);
            // }
            //
            // Console.WriteLine("By Age");
            // o.PrintByAge();
            //
            // var pic = new Picture();
            // pic.Draw();
            // ((IDraw)pic).Draw();
            // var big = new BigPicture();
            // big.Draw();
            // ((IDraw)big).Draw();

            Assembly a = Assembly.UnsafeLoadFrom(@"c://Users/Karol/Documents/visual/wizualne/TestKlas/HiddenLibrary.dll");
            foreach (var m in a.GetTypes())
            {
                Console.WriteLine(m.Name);
                if (m.Name == "TechnicalUniveristy")
                {
                    var obj = Activator.CreateInstance(m,  "PUT" );
                    Console.WriteLine("activated");
                    foreach (var func in m.GetMethods())
                    {
                        Console.WriteLine(func);
                    }

                    string s = (string)m.GetMethod("ShowInfo").Invoke(obj, null);
                    Console.WriteLine(s);
                }
                // foreach (var i in m.GetConstructors())
                // {
                //     foreach (var par in i.GetParameters())
                //     {
                //         Console.WriteLine("\t" + par.Name + " " + par.ParameterType);
                //     }
                //     
                // }
            }
            return 0;
        }
    }
}