using System;
namespace Day9
{
    class Trenini
    {
        public void Menu()
        {
            ZvaigzniteVaiRestite();
            Console.ReadLine();
        }

        private void Restites()
        {
            //cilveks ievada vertibu, kas ir skaitlis (int)
            int skaitlis = SkaitlaIevade();
            //izvadit tik restites, cik cilveks ir ievadijis skaitli
            for (int i = 0; i < skaitlis; i++)
            {
                Console.Write("#");

            }
        }
        private int SkaitlaIevade()
        {

            Console.WriteLine("Ievadiet skaitli!");
            String simboluVirkne = Console.ReadLine();
            int result = Convert.ToInt16(simboluVirkne);

            return result;
        }
        private void Restite3()
        {
            int skaitlis = SkaitlaIevade();

            char[] restites = new char[skaitlis];

            for (int i = 0; i < skaitlis; i++)
            {
                restites[i] = '#';
                Console.Write(restites[i]);
            }

        }
        private void Restite4()
        {
            String[] reste = new string[5] { "#", "##", "###", "####", "#####" };
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(reste[i]);
            }
            Console.WriteLine();
        }

        //bonuss, ja izmantojot try-catch parbaudaisiet ievadi


        private void Faktorials() // saskaita visus skaitljus kurus ietver ievaditais skaitlis
        {

            int skaitlis = SkaitlaIevade();

            int fak = 0;

            for (int i = 1; i <= skaitlis; i++)
            {
                fak = fak + i;

            }
            Console.WriteLine("Rezultats ir " + fak);
        }


        private void ZvaigzniteVaiRestite()
        {
            // % daliishana
            // 4 % 2 = 0
            // 6 % 3 = 0
            // 5 % 4 = 1
            String[] vii = new string[8];

            //ja masiva indekss dalas bez atlikuma, ielikt *
            //ja ne tad restiti


            for (int i = 0; i < vii.Length; i++)
            {
                if (i % 2 == 0)
                {
                    vii[i] = "*";
                }
                else
                {
                    vii[i] = "#";
                }

            }
            Console.Write(vii[i] + " ");

        }

    }
}


