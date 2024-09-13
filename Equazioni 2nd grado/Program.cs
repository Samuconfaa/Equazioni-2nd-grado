using System.Data;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        double a;
        double b;
        double c;
        
       

        calcolo(a, b, c);

        



    }

    public static void assegnazione()
    {
        Console.WriteLine("Ciao, risolverò la tua equazione di secondo grado! \nPer iniziare inserisci il valore di a" +
    ".\nP.S.: la forma è aX^ + bX + c = 0");
        string input = Console.ReadLine();
        a = double.Parse(input);

        Console.WriteLine("Ora inserisci il valore di b");
        input = Console.ReadLine();
        b = double.Parse(input);

        Console.WriteLine("E infine il valore di c");
        input = Console.ReadLine();
        c = double.Parse(input);
    }
    public static void calcolo(double a, double b, double c)
    {

        double risultato;
        if (a != 0 || b != 0 || c != 0)
        {
            if (c == 0)
            {
                if (b == 0)
                {
                    soloA();
                }
                else if (a != 0)
                {
                    risultato = -b / a;
                    Console.WriteLine("X1 = 0; X2 = " + risultato);
                }
                else if (a == 0)
                {
                    Console.WriteLine("Non è una equazione di secondo grado!");
                }
            }
            else if (b == 0)
            {
                if (c == 0)
                {
                    soloA();
                }
                else if (a != 0)
                {
                    if (Math.Sign(a) == Math.Sign(c))
                    {
                        impossibile();
                    }
                    else
                    {
                        risultato = Math.Sqrt(c / a);
                        double risultatoOpposto = -risultato;
                        Console.WriteLine("X1 = " + risultato + " ; X2 = " + risultatoOpposto);
                    }
                }
                else
                {
                    impossibile();
                }
            }
            else if (a == 0)
            {
                Console.WriteLine("Non è una equazione di secondo grado");
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double radiceDelta = Math.Sqrt(delta);
                    double x1 = (-b + radiceDelta) / (2 * a);
                    double x2 = (-b - radiceDelta) / (2 * a);
                    Console.WriteLine("X1 = " + x1 + "; X2 = " + x2);
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("X = " + x);
                }
                else
                {
                    Console.WriteLine("Equazione impossibile (nessuna soluzione reale).");
                }
            }


        }
        else
        {
            Console.WriteLine("Hai inserito tutti valori nulli!");
        }
    }

    public static void soloA()
    {
        Console.WriteLine("X1 = 0 ; X2 = 0");
    }

    public static void impossibile()
    {
        Console.WriteLine("Equazione impossibile");
       
    }
}