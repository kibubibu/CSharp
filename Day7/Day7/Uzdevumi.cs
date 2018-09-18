using System;
namespace Day7
{
    class Uzdevumi
    {
        public void Izvelne()
        {
            Viendimensiju();
        }

        private void Viendimensiju()
        {
            int garums = 0;
            while (garums < 1 || garums > 9)
            {
                garums = Ievade();
                if (garums < 1 || garums > 9)
                {
                    Console.WriteLine("ievade nav pareiza");
                }
            }
            String[] daudzasVirknes = new String[garums];

            for (int i = 0; i < garums; i++)
            {
                Console.WriteLine("ievadiet vertibu");
                daudzasVirknes[i] = Console.ReadLine();
                if (daudzasVirknes[i].Length > 6)
                {
                    daudzasVirknes[i] = "!Error";
                }
            }
            for (int i = 0; i < garums; i++)
            {
                Console.WriteLine(daudzasVirknes[i]);

            }
        }
        private int Ievade()
        {
            int result = 0;
            try
            {
                Console.WriteLine("ievadiet garumu");
                String input = Console.ReadLine();
                result = Convert.ToInt16(input);
            }
            catch(Exception ex)
            {
                Console.WriteLine("nepareiza ievade, masivam pieskjirts garums5");
                Console.WriteLine(ex.Message);
                result = 5; //var nebut
            }
            return result;
      
        }


        private void Divdimensiju(){

        

                

        }

    }
}
