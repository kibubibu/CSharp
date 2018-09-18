using System;
namespace Day3
{
    public class Matematika
    {
        public void Saskaitit()
        {
            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int summa = a + b;

            Console.WriteLine(summa);
        }

        public void Atnemsana()
        {
            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int rezultats = a - b;

            Console.WriteLine(rezultats);
        }



        public void Apvienota()
        {
            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();
            Console.WriteLine("Ievadiet 1, lai saskaitītu, vai 2, lai atnemtu");
            String izvele = Console.ReadLine();

            if (izvele == "1")
            {
                Console.WriteLine(a + b);
            }
            else if (izvele == "2")
            {
                Console.WriteLine(a - b);
            }
            else
            {
                Console.WriteLine("Izvade nav pareiza");
            }

        }
        private int SkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            return jaunaisSkaitlis;
        }




        //5x prasa ievadit vardu, savieno teikumaa
        public void Teikums()
        {
            String teikums = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet vardu: ");
                String jaunsvards = Console.ReadLine();
                teikums = teikums + " " + jaunsvards;
            }
            Console.WriteLine(teikums);
        }


        //ievada skaitli, ievada pakaapi
        public void Kapinasana()
        {
            int skaitlis = SkaitlaIevade();
            int pakape = SkaitlaIevade();

            int rezultats = 1;
            for (int i = 0; i < pakape; i++)
            {
                rezultats = rezultats * skaitlis;
            }
            Console.WriteLine(rezultats);
        }
    }
}
