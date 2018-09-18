using System;
namespace Day4
{
    public class Matematika //kalkulatorins
    {
        public void Darisana()
        {
            String choice = "";

            while (choice != "iziet")
            {


                Console.WriteLine("ievadiet simbolus- +, -, ^, vai iziet");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "+":
                        Saskaitit();
                        break;
                    case "-":
                        Atnemsana();
                        break;
                    case "^":
                        Kapinasana();
                        break;
                    case "iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }

            
        }
        private void Saskaitit()
        {
            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int summa = a + b;

            Console.WriteLine(summa);
        }

        private void Atnemsana()
        {
            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int rezultats = a - b;

            Console.WriteLine(rezultats);
        }




        //ievada skaitli, ievada pakaapi
        private void Kapinasana()
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
                

        private int SkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            return jaunaisSkaitlis;
        }

    }
}


        
        
    

