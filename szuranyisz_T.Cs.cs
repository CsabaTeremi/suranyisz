using System;

namespace szuranyisz_T_Cs_
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello world!");
        }

        static void F2()
        {
            string name = "masodikfeladat";
            Console.WriteLine("Szia " + name);
        }

        static void F3()
        {
            Console.Write("Adjon meg egy számot: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number * 2);
        }

        static void F4()
        {
            int elso = 2;
            int masodik = 3;

            Console.WriteLine("Összeg: " + (elso + masodik));
            Console.WriteLine("Különbség: " + (elso - masodik));
            Console.WriteLine("Szorzat: " + (elso * masodik));
            Console.WriteLine("Hányados: " + ((double)elso / masodik));
        }

        static void F5()
        {
            int elsoszam = 4;
            int masodikszam = 5;
            if (elsoszam > masodikszam)
                Console.WriteLine(masodikszam);
            else
                Console.WriteLine(elsoszam);
        }

        static void F6()
        {
            int e1 = 10;
            int e2 = 20;
            int e3 = 30;

            if (e1 <= e2 && e1 <= e3)
                Console.WriteLine("Legkisebb: " + e1);
            else if (e2 <= e1 && e2 <= e3)
                Console.WriteLine("Legkisebb: " + e2);
            else
                Console.WriteLine("Legkisebb: " + e3);
        }

        static void F7()
        {
            int a = 30;
            int b = 50;
            int c = 100;

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("A háromszög megszerkeszthető");
            else
                Console.WriteLine("A háromszög nem szerkeszthető meg");
        }

        static void F8()
        {
            Console.Write("Adj meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int b = int.Parse(Console.ReadLine());

            double szamtani = (a + b) / 2.0;
            double mertani = Math.Sqrt(a * b);

            Console.WriteLine("Számtani közép: " + szamtani);
            Console.WriteLine("Mértani közép: " + mertani);
        }

        static void F9()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;
            if (D < 0)
                Console.WriteLine("Nincs valós megoldás");
            else
                Console.WriteLine("Van megoldás");
        }

        static void F10()
        {
            Console.Write("a = ");
				double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
				double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
				double c = double.Parse(Console.ReadLine());

				double D = b * b - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("Nincs valós megoldás");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Egy megoldás: x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Két megoldás: x1 = " + x1 + ", x2 = " + x2);
            }
        }

        static void F11()
        {
            Console.Write("Első befogó: ");
				double a = double.Parse(Console.ReadLine());
            Console.Write("Második befogó: ");
				double b = double.Parse(Console.ReadLine());

				double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Az átfogó hossza: " + c.ToString("F2"));
        }

  static void F12()
        {
            Console.Write("Téglatest hossza: ");
				double h = double.Parse(Console.ReadLine());
            Console.Write("Téglatest szélessége: ");
				double sz = double.Parse(Console.ReadLine());
            Console.Write("Téglatest magassága: ");
				double m = double.Parse(Console.ReadLine());
				double te = h * m * sz;
				double f = 2 * ((h * m) + (m * sz) + (sz * h));
            Console.WriteLine($"A téglatest felszíne {f}.");
            Console.WriteLine($"A téglatest térfogata {te}.");
        }

        static void F13()
        {
            Console.Write("Kör átmérője: ");

				double d = double.Parse(Console.ReadLine());
				double r = d / 2;
	
				double r2 = Math.Pow(r, 2);

				double k = r * Math.PI * 2;
				double t = r2 * Math.PI;

            Console.WriteLine($"A kör kerülete: {Math.Round(k, 2)}");
            Console.WriteLine($"A kör területe: {Math.Round(t, 2)}");

         static void F14()
        {
            Console.Write("Körív sugra: ");

				double R = double.Parse(Console.ReadLine());
	
            Console.Write("Középponti szög: ");

				double fok = double.Parse(Console.ReadLine());

				double cikkT = (fok / 360) * Math.Pow(R, 2) * Math.PI;
				double ivK = (fok / 360) * (2 * R) * Math.PI;

            Console.WriteLine($"A területe: {Math.Round(cikkT, 2)}");
            Console.WriteLine($"A határoló hossza: {Math.Round(ivK, 2)}");
        }

    }
}
