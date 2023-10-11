
class Zadania2
{
    static void Main(string[] args)
    {
        p21();
        zad_21();
        zad_22();
        zad_23();
        zad_24();
        //zad_25();
        zad_26();
        zad_27();
        zad_28();
    }

    static void p21()
    {
        int suma = 0;
        int ocena;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Podaj ocenę: ");
            ocena = Convert.ToInt32(Console.ReadLine());
            suma += ocena;
        }
        double srednia = suma / (double)10;
        Console.WriteLine("Średnia z ocen wynosi: {0:N}", srednia);
    }

    static void zad_21()
    {
        int suma = 0;
        int ocena;
        int licznik = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Podaj ocenę: ");
            ocena = Convert.ToInt32(Console.ReadLine());
            if (ocena > 2)
            {
                suma += ocena;
                licznik++;
            }
        }
        double srednia = suma / (double)licznik;
        Console.WriteLine("Średnia z ocen wynosi: {0:N}", srednia);
    }

    static void zad_22()
    {
        double oprocentowanie = 0.06;

        Console.Write("Podaj kwotę, którą chcesz umieścić na lokacie: ");
        double kwota = Int32.Parse(Console.ReadLine());

        Console.Write("Podaj na ile lat deponujesz pieniądze: ");
        int lata = Int32.Parse(Console.ReadLine());

        double wynik = kwota * Math.Pow((1 + oprocentowanie), lata);

        Console.WriteLine("Wartość inwestycji {0:c} po {1} latach = {2:c}", kwota, lata, wynik);
    }

    static void zad_23()
    {
        Console.Write("Podaj 5 liczb oddzielając je przecinkami: ");
        string liczby = Console.ReadLine();
        string[] liczby_str = liczby.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
        
        if (liczby_str.Length != 5)
        {
            Console.WriteLine("Błąd! Podaj dokładnie 5 liczb.");
            return;
        }

        int[] liczby_int = new int[5];

        for (int i = 0; i <5; i++)
        {
            liczby_int[i] = Int32.Parse(liczby_str[i]);
        }

        int najmniejsza = liczby_int[0];
        int najwieksza = liczby_int[0];

        for (int i = 1; i < 5; i++)
        {
            if (liczby_int[i] > najwieksza)
            {
                najwieksza = liczby_int[i];
            }
            if (liczby_int[i] < najmniejsza)
            {
                najmniejsza = liczby_int[i];
            }
        }

        Console.WriteLine($"Największa liczba to: {najwieksza}");
        Console.WriteLine($"Najmniejsza liczba to: {najmniejsza}");
    }

    static void zad_24()
    {
        int K = 120;
        double S = 1.8;

        Console.Write("Podaj długość skoku: ");
        double d = Double.Parse(Console.ReadLine());

        double pd = 60 + (d - K) * S;

        Console.Write("Podaj oceny sędziów oddzielając je przecinkami: ");
        string oceny = Console.ReadLine();
        string[] oceny_str = oceny.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

        if (oceny_str.Length != 5)
        {
            Console.WriteLine("Błąd! Podaj dokładnie 5 liczb.");
            return;
        }

        int[] oceny_int = new int[5];

        double ps = 0;

        for (int i = 0; i < 5; i++)
        {
            oceny_int[i] = Int32.Parse(oceny_str[i]);
            ps += oceny_int[i];
        }

        int najmniejsza = oceny_int[0];
        int najwieksza = oceny_int[0];

        for (int i = 1; i < 5; i++)
        {
            if (oceny_int[i] > najwieksza)
            {
                najwieksza = oceny_int[i];
            }
            if (oceny_int[i] < najmniejsza)
            {
                najmniejsza = oceny_int[i];
            }
        }

        ps -= (najmniejsza + najwieksza);

        double p = pd + ps;

        Console.WriteLine($"Liczba puntkow zdobytych przez skoczka to: {p:2}");
    }

    static int zad_25(int n)
    {
        //Console.Write("Podaj liczbę, dla której chcesz obliczyć silnię: ");
        //int n = Int32.Parse(Console.ReadLine());

        if (n == 0 || n == 1)
        {
            //Console.WriteLine($"{n}! = 1");
            return 1;
        }
        else
        {
            int silnia = 1;
            for(int i = 1; i <= n; i++)
            {
                silnia *= i;
            }
            //Console.WriteLine($"{n}! = {silnia}");
            return silnia;
        }
    }

    static void zad_26()
    {
        Console.Write("Podaj liczbę do sprawdzenia czy jest liczbą pierwszą: ");
        int n = Int32.Parse(Console.ReadLine());

        if(n < 2)
        {
            Console.WriteLine($"Liczba {n} nie jest liczba pierwszą");
            return;
        }

        for (int i = 2; i*i <= n; i++) 
        {
            if(n%i == 0)
            {
                Console.WriteLine($"Liczba {n} nie jest liczba pierwszą");
                return;
            }
        }
        Console.WriteLine($"Liczba {n} jest liczba pierwszą");
    }

    static bool liczba_pierwsza(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    static void zad_27()
    {
        Console.Write("Podaj dolną granicę przedziału a (liczba całkowita): ");
        
        int a;
        if (int.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Podaj górną granicę przedziału b (liczba całkowita większa od a): ");
            
            int b;
            if ((int.TryParse(Console.ReadLine(), out b)) && b > a)
            {
                Console.Write($"Liczby pierwsze w przedziale [{a} {b}]: ");
                for(int i = a; i <= b; i++)
                {
                    if(liczba_pierwsza(i))
                    {
                        Console.Write(i + ", "); 
                    }
                }
                Console.WriteLine();
            }
        }
    }

    static void zad_28()
    {
        Console.Write("Podaj n: ");
        int n;

        if(int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Podaj k (k<=n): ");
            int k;

            if((int.TryParse(Console.ReadLine(), out k) && (k <= n)))
            {
                long symbol_Newtona;
                if (k == 0 || k == n)
                {
                     symbol_Newtona = 1;
                }
                else
                {
                    long licznik = zad_25(n);
                    long mianownik = zad_25(k) * zad_25(n - k);
                    symbol_Newtona = licznik / mianownik;
                }

                Console.WriteLine($"Symbol Newtona dla n = {n} i k = {k} wynosi {symbol_Newtona}");

            }
        }
    }
}