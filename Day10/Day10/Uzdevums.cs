using System;
namespace Day10
{
    class Uzdevums
    {
        public void Karatavas()
        {
            Stripinas();
            Console.ReadLine();
        }


        public void Stripinas()
        {
          
            char[] stripinas = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
            for (int i = 0; i < stripinas.Length; i++)
            {

                Console.Write(stripinas[i]);
            }
            Console.WriteLine();


            BurtaIevade();
        }



        public void Burtini()
        {
            char burts = BurtaIevade();

            char[] burtini = { 'P', 'R', 'O', 'G', 'R', 'A', 'M', 'M', 'E', 'S', 'A', 'N', 'A' };

            for (int i = 0; i < burtini.Length; i++)
            {
                if (burts == burtini[i])

                {
                  //  Console.WriteLine();
                
                }
                else
                {
                  //  Console.WriteLine();
                }
            }

        }

        


        public char BurtaIevade()
        {

            Console.WriteLine("Ievadiet burtu!");
            String burts = Console.ReadLine();
            char result = Convert.ToChar(burts);

            return result;
        }
    }
}