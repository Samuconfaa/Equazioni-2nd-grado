using System.Data;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        programma();
    }

    public static void programma()
    {
        inizio();
        restart();
    }

    public static void restart()
    {
        Console.WriteLine("Premi il tasto 0 se vuoi risolvere un'altra operazione, altrimenti un tasto qualsiasi.");
        string restart = Console.ReadLine();
        if (restart != null && restart.Equals("0"))
        {
            programma();
        }
    }

    public static void inizio()
    {
        Console.WriteLine("Sono in grado di risolvere le equazioni di secondo grado! \nLa forma è aX^ + bX + c = 0");
        double a = assegnazione("Inserisci il valore di a");
        double b = assegnazione("Inserisci il valore di b");
        double c = assegnazione("Inserisci il valore di c");

        calcolo(a, b, c);
    }

    public static double assegnazione(string frase)
    {
        Console.WriteLine(frase);
        string valore = Console.ReadLine();
        return double.Parse(valore);
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