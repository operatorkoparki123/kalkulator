using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Kalkulator");
            Console.WriteLine("Wybierz równanie");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Potęgowanie");
            Console.WriteLine("6. Pierwiastkowanie");
            Console.WriteLine("7. Funkcje trygonometryczne");
            Console.WriteLine("8. Wyjście");

            string wybór = Console.ReadLine();

            switch (wybór)
            {
                case "1":
                    Suma();
                    goto Start;
                    
                case "2":
                    Różnica();
                    goto Start;
                    
                case "3":
                    Iloczyn();
                    goto Start;
                    
                case "4":
                    Iloraz();
                    goto Start;
                    
                case "5":
                    Potęga();
                    goto Start;
                    
                case "6":
                    Pierwiastek();
                    goto Start;
                    
                case "7":
                    funTryg();
                    goto Start;
                    
                case "8":
                    Wyjscie();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wybierz coś z listy!");
                    Console.ReadKey();
                    goto Start;

                  
            }
        }
        static void Suma()
        {
            Console.Clear();
            Console.WriteLine("Dodawanie");
            Console.WriteLine("Podaj pierwszą liczbę:");
            double liczba1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double liczba2 = Convert.ToDouble(Console.ReadLine());
            double suma = liczba1 + liczba2;
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Aby wrócić do kalkulatora kliknij ENTER");
            Console.ReadKey();
            Console.Clear();

        }
        static void Różnica()
        {
            Console.Clear();
            Console.WriteLine("Odejmowanie");
            Console.WriteLine("Podaj pierwszą liczbę:");
            double liczba1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double liczba2 = Convert.ToDouble(Console.ReadLine());
            double odejmowanie = liczba1 - liczba2;
            Console.WriteLine("Różnica: " + odejmowanie);
            Console.WriteLine("Aby wrócić do kalkulatora kliknij ENTER");
            Console.ReadKey();
            Console.Clear();
        }
        static void Iloczyn()
        {
            Console.Clear();
            Console.WriteLine("Mnożenie");
            Console.WriteLine("Podaj pierwszą liczbę:");
            double liczba1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double liczba2 = Convert.ToDouble(Console.ReadLine());
            double mnożenie = liczba1 * liczba2;
            Console.WriteLine("Iloczyn: " + mnożenie);
            Console.WriteLine("Aby wrócić do kalkulatora kliknij ENTER");
            Console.ReadKey();
            Console.Clear();
        }
        static void Iloraz()
        {
            Console.Clear();
            wroc:
                Console.WriteLine("Dzielenie");
                Console.WriteLine("Podaj pierwszą liczbę:");
                double liczba1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę:");
                double liczba2 = Convert.ToDouble(Console.ReadLine());
                double dzielenie = liczba1 / liczba2;
            if (liczba2 == 0 )
            { 
                Console.WriteLine("Nie dzielimy przez zero! Kliknij ENTER, aby spróbować ponownie!");
                Console.ReadKey();
                Console.Clear();
                goto wroc;
            }
            else
            { 
                Console.WriteLine("Iloraz: " + dzielenie); 
            }
            Console.WriteLine("Aby wrócić do kalkulatora kliknij ENTER");
                Console.ReadKey();
                Console.Clear();
            
        }
        static void Potęga()
        {
            Console.Clear();
            Console.WriteLine("Potęgowanie");
            Console.WriteLine("Podaj pierwszą liczbę:");
            double liczba1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double liczba2 = Convert.ToDouble(Console.ReadLine());
            double potęgowanie = Math.Pow(liczba1, liczba2);
            Console.WriteLine("Potęga: " + potęgowanie);
            Console.WriteLine("Aby wrócić do kalkulatora kliknij ENTER");
            Console.ReadKey();
            Console.Clear();
        }
        static void Pierwiastek()
        {
            Console.Clear();
            Console.WriteLine("Pierwiastki");
            Console.WriteLine("Podaj liczbę:");
            double liczba = Convert.ToDouble(Console.ReadLine());
            double pierw = Math.Sqrt(liczba);
            Console.WriteLine("Pierwiastek: " + pierw);
            Console.WriteLine("Aby wrócić do kalkulatora kliknij ENTER");
            Console.ReadKey();
            Console.Clear();
        }
        static void funTryg()
        {
            Console.Clear();
            Console.WriteLine("Funkcja Trygonometryczna");
            Console.WriteLine("Podaj kąt");
            double angle = Convert.ToDouble(Console.ReadLine());
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double tan = Math.Tan(angle);
            Console.WriteLine("Sin: " + sin);
            Console.WriteLine("Cos: " + cos);
            Console.WriteLine("Tan: " + tan);
            Console.WriteLine("Aby wrócić do kalkulatora kliknij ENTER");
            Console.ReadKey();
            Console.Clear();
        }
        static void Wyjscie()
        {
            Console.WriteLine("Pa pa!");
            Environment.Exit(0);
        }
    }
}
