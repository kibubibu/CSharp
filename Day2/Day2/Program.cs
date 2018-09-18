using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)

        {
            int reizes = SkaitlaIevade();
            Zvaigzne(reizes);
            Console.ReadLine();
        }
        //     Piemers();
        //    Piemers2(3, 6);


        //    int skaitlis = Piemers3();

        //    Console.ReadLine();
        //}
        ////}
        //static void Piemers()
        //// {
        //// cikli = for, while, do..while, foreach
        //{
        //    for (int i = 0; i < 5; i++) //iet cauri 5x
        //    {
        //        Console.WriteLine(i);
        //    }
        //    for (int i = 4; i > -1; i--)
        //    {
        //        Console.WriteLine(i);
        //    }


        //    int j = 0;
        //    while (j < 5)
        //    {
        //        Console.WriteLine(j);
        //        j++;
        //    }

        //    j = 0;

        //    do  //do while parbauda beigaas, while paarbauda saakumaa (ja nez, cik reizes jaizpilda)
        //    {
        //        Console.WriteLine(j);
        //        j++;
        //    } while (j < 5);


        //    String zvaigzne = "*";
        //    for (int k = 0; k < 4; k++)

        //    {
        //        Console.WriteLine(zvaigzne);
        //        zvaigzne = zvaigzne + "*";
        //    }
        //}
        //static void Piemers2(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}

        //static void Piemers3()
        //{
        //    int rezultats = 6 + 8;

        //    return rezultats; //atdod vertiibu
        //}




        //    Console.WriteLine("ievadi skaitli");
        //    String simboluVirkne = Console.ReadLine();
        //int jaunaisSkaitlis1 = Convert.ToInt16(simboluVirkne);
        //Console.WriteLine("ievadi vel vienu skaitli");
        //    simboluVirkne = Console.ReadLine();
        //    int jaunaisSkaitlis2 = Convert.ToInt16(simboluVirkne);

        //int summa = Saskaitisana(jaunaisSkaitlis1, jaunaisSkaitlis2);

        //    static void Saskaitisana()
        // {
        //    int a;
        //    int b;
        //    a = SkaitlaIevade();
        //    b = SkaitlaIevade();
        //    int summa = a + b;

        //    Console.WriteLine(summa);


        //}
    }
        static int SkaitlaIevade()

        {
            Console.WriteLine("ievadi skaitli");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            return jaunaisSkaitlis;
        }
        //    Console.ReadLine();

    }


    static int Saskaitisana(int skaitlis, int skaitlis2)
    {
        int rezultats = skaitlis + skaitlis2;
        return rezultats;
    }




        


        static void Zvaigzne(int robeza)
        {
            String zvaigzne = "*";
            for (int k = 0; k < robeza; k++)

            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + "*";
            }



        }
    }

}