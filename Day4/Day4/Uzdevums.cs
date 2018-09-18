using System;
namespace Day4
{
    public class Uzdevums
    {
        //private int a = 4;
        //public int a = 6;


        public void Interfeiss()
        {
            GarumaParbaude();
        }

        private void GarumaParbaude()
        {
            Console.WriteLine("ievadiet simbolus: ");
            String simboli = Console.ReadLine();


            if (simboli.Length > 1 && simboli.Length < 13)
            {
                Console.WriteLine("viss ir ok");
            }
            else 
            {
                Console.WriteLine("nepareiza ievade");
            
        }
    }
        private void Izvelne()
        {
            String c = "11";

            switch (c)
            {
                case "0": // eerts kad zina ka buus daudz konkreetas veertiibas
                    Console.WriteLine("vii");
                    break;
                case "1":
                    Console.WriteLine("vii2");
                    break;
                default:
                    Console.WriteLine("nepareiza ievade");
                    break;
            }

        }
        //cilevks ievada simbolu virkni
        //vorknes garumam jabut min 1, max 12 simboli
        //ja neatbilst, izvada "nepareiza ievade"
        //ja atbilst, izvade "viss ir ok"

        public void Menu()
        {
            String choice = "";

            while (choice != "iziet")
            {


                Console.WriteLine("ievadiet simbolus- 1, 2, 3, vai iziet");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // ljauj izveleties no vairakam ocijam vai izeit
                        Console.WriteLine("vii");
                        break;
                    case "2":
                        Console.WriteLine("vii2");
                        break;
                    case "3":
                        Console.WriteLine("vii");
                        break;
                    case "iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }

            }
        }
                //cilveks ievada simbolu virkni
                //lai to vinam liek darit, kamer nav ievadijis vardu "iziet"

            public void Cikli()
            {

            int k = 0;
            String zvaigzne = "*";
            while (k < 4)
            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + "*";
                k++;

            }
        }
    }
}
