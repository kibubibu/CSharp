using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //Piemers();
            //Piemers2(3, 5);
            //Piemers2(2, 7);

            //int skaitlis = Piemers3();

            //Console.WriteLine(skaitlis);

            //Saskaitisana();
            int reizes = SkaitlaIevade();
            Zvaigzne(reizes);
            Console.ReadLine();
        }

        static void Piemers()
        {
            //for, while, do..while, foreach

            for (int i = 0; i < 5; i++) //iet tik reizhu, cik uzliek
            {
                Console.WriteLine(i);
            }
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(i);
            }

            int j = 5;
            while (j < 5)  //piemerots, kad nezina, cik ilgi cikls bus jaiet cauri, parbauda nosacijumu sakaumaa (neieies ciklaa)
            {
                Console.WriteLine(j);
                j++;
            }

            //j = 0;

            do  //parbauda nosacijumu beigaas (ieies vienu reizi)
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);

            //*
            //**
            //***
            //****
            String zvaigzne = "*";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + '*';
            }
        }

        static void Piemers2(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int Piemers3()
        {
            int rezultats = 6 + 8;

            return rezultats;
        }

        //uztaisit funkciju, kas saskaita 2 lietotaja ievaditus skaitlus
        //jaizmanto parametri un return

        static void Saskaitisana()
        {
            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int summa = a + b;
            Piemers();

            Console.WriteLine(summa);
        }

        static int SkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            return jaunaisSkaitlis;
        }

        static void Zvaigzne(int robeza)
        {
            String zvaigzne = "*";
            for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + '*';
            }
        }
    }
}
