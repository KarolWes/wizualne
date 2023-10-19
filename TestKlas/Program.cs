namespace wizualne
{
    class Demo
    {
        static int Main(String[] args)
        {
            OfficeWorker w = new OfficeWorker("Karol", "Wesolowski",
                new DateTime(2001, 2, 22)) { Imie = "Antoni"};
            Console.WriteLine(w);
            
            Manager m = new Manager("Jan", "Nowak",
                new DateTime(2000, 1, 2));
            Console.WriteLine(m);
            Supervisor s = new Supervisor();
            Console.WriteLine(s);


            Point p = new Point();

            Console.WriteLine(p.x);
            
            (var Imie, var Nazwisko, var wiek) = ("Jan", "Nowak", 33);

            Console.WriteLine(Imie);
            
            var (Imie2, Nazwisko2, wiek2) = ("Andrzej", "Nowak", 33);
            Console.WriteLine(Imie2);
            var pracownik = ("Wojciech", "Nowak", 33);
            Console.WriteLine(pracownik.Item1);
            (string Imie, string Nazwisko, int Wiek) prac = ("Adam", "Nowak",
                33);
            Console.WriteLine(prac.Imie);
            return 0;   
        }
    }
}