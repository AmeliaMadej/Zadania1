static void p11()
{
    Console.WriteLine("Hello World!!!");
}
p11();

static void p12()
{
    Console.Write("Podaj promień: ");
    double r = Double.Parse(Console.ReadLine());
    double obwod = 2 * Math.PI * r;
    Console.WriteLine("Obwod wynosi: {0:0.##}", obwod);
    Console.WriteLine();
}
p12();

static void zad_11()
{
    Console.Write("Podaj promien okregu: ");
    double r = Double.Parse(Console.ReadLine());
    if(r < 0)
    {
        Console.WriteLine("Niepoprawne dane");
    }
    else
    {
        double pole = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("Pole kola wynosi: {0:0.00}", pole);
    }

    Console.WriteLine();
}
zad_11();

static void zad_12()
{
    Console.Write("Podaj dlugosc pierwszego boku prostokata: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Podaj dlugosc drugiego boku prostokata: ");
    int b = Int32.Parse(Console.ReadLine());
    int pole = a * b;
    Console.WriteLine("Pole prostokata wynosi {0}", pole);
    if( a == b)
    {
        Console.WriteLine("Ten prostokat jest kwadratem");
    }
    else
    {
        Console.WriteLine("Ten prostokat nie jest kwadratem");
    }

    Console.WriteLine();
}
zad_12();

static void zad_13()
{
    Console.Write("Podaj liczbe calkowita: ");
    int a = Int32.Parse(Console.ReadLine());
    if( a % 2 == 0)
    {
        Console.WriteLine("Liczba {0} jest parzysta", a);
    }
    else
    {
        Console.WriteLine("Liczba {0} jest nieparzysta", a);
    }

    Console.WriteLine();
}
zad_13();

static void zad_14()
{
    Console.Write("Podaj pierwsza liczbe: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Podaj druga liczbe: ");
    int b = Int32.Parse(Console.ReadLine());
    Console.Write("Podaj trzecia liczbe: ");
    int c = Int32.Parse(Console.ReadLine());

    int max = a;
    
    if( b > max)
    {
        max = b;
    }
    if( c > max)
    {
        max = c;
    }
    
    Console.WriteLine("Max({0}, {1}, {2}) = {3}", a, b, c, max);

    Console.WriteLine();
}
zad_14();


static void zad_15()
{
    Console.WriteLine("Program do obliczania miejsc zerowych równania kwadratowego ax^2 + bx + c = 0");
    
    Console.Write("Podaj wspolczynnik a: ");
    double a = Double.Parse(Console.ReadLine());

    Console.Write("Podaj wspolczynnik b: ");
    double b = Double.Parse(Console.ReadLine());

    Console.Write("Podaj wspolczynnik c: ");
    double c = Double.Parse(Console.ReadLine());

    double delta = b * b - 4 * a * c;

    if (delta > 0)
    {
        double x1 = (-b + Math.Sqrt(delta) / (2 * a));
        double x2 = (-b - Math.Sqrt(delta) / (2 * a));

        Console.WriteLine("Miejsca zerowe funkcji {0}x^2 + {1}x + {2} to x1 = {3}, x2 = {4}", a, b, c, x1, x2);
    }
    else if (delta == 0)
    {
        double x0 = (-b) / (2 * a);
        Console.WriteLine("Miejsce zerowe funkcji {0}x^2 + {1}x + {2} to x0 = {3}", a, b, c, x0);

    }
    else
    {
        double re = (-b) / (2 * a);
        double im = Math.Sqrt(-delta) / (2 * a);
        Console.WriteLine("Miejsca zerowe funkcji {0}x^2 + {1}x + {2} to x1 = {3} + {4:0.00}i, x2 = {5} - {6:0.00}i", a, b, c, re, im, re, im);
    }

    Console.WriteLine();
}
zad_15();


static void p13()
{
    Console.Write("Podaj liczbę całkowitą z przedziału [2 4]: ");
    int a = Int32.Parse(Console.ReadLine());

    switch (a)
    {
        case 2:
            Console.WriteLine("Podałeś liczbę 2");
            break;
        case 3:
            Console.WriteLine("Podałeś liczbę 3");
            break;
        case 4:
            Console.WriteLine("Podałeś liczbę 4");
            break;
        default:
            Console.WriteLine("Podałeś liczbę spoza przedziału [2 4]");
            break;
    }
}


static void zad_16()
{
    Console.Write("Podaj kwote w zlotowkach: ");
    int kwota_PLN = Int32.Parse(Console.ReadLine());

    Console.Write("Okresl walute (USD/EUR/GBP/CHF/CZK): ");
    string waluta = Console.ReadLine().ToUpper();

    switch (waluta)
    {
        case "USD":
            double kurs_USD = 4.33;
            Console.WriteLine("{0:0.00} zl to {1:0.00} USD", kwota_PLN, kwota_PLN / kurs_USD);
            break;

        case "EUR":
            double kurs_EUR = 4.56;
            Console.WriteLine("{0:0.00} zl to {1:0.00} EUR", kwota_PLN, kwota_PLN / kurs_EUR);
            break;

        case "GBP":
            double kurs_GBP = 5.28;
            Console.WriteLine("{0:0.00} zl to {1:0.00} GBP", kwota_PLN, kwota_PLN / kurs_GBP);
            break;

        case "CHF":
            double kurs_CHF = 4.77;
            Console.WriteLine("{0:0.00} zl to {1:0.00} CHF", kwota_PLN, kwota_PLN / kurs_CHF);
            break;

        case "CZK":
            double kurs_CZK = 0.18;
            Console.WriteLine("{0:0.00} zl to {1:0.00} CZK", kwota_PLN, kwota_PLN / kurs_CZK);
            break;

    }
}
zad_16();

