
class Zadania2
{
    static void Main(string[] args)
    {
        p21();
        zad_21();
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
        int lata;
        double kwota;
        double oprocentowanie = 0.06;
        Console.Write("Podaj kwotę, którą chcesz umieścić na lokacie: ");
    }
}