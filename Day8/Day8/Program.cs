using System;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
       

            PirmaisPiemers piem = new PirmaisPiemers();
            //piem.DarbibaArMasivu();


            String izvele = "";

            while(izvele!= "iziet")
            {
                Console.WriteLine("Nospiediet 1, lai ");
                izvele = Console.ReadLine();
                switch (izvele)
                {
                    case "1":
                        piem.DarbibaArMasivu();
                        break;
                    case "2":
                        piem.Stripinas();
                        break;
                    case "0":
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }
    }
}
