using System;
namespace Day8
{
    class PirmaisPiemers
    {
        public void DarbibaArMasivu()
        {
            //viendimensiju masivs
            //ta lai cilveks ievada vertibas
            //masiva garums 4


            String[] pirmaisMasivs = new string[4];

            String ievade = "";
            while (ievade != "iziet")  //nosaka cik ilgi pildit ciklu

            {
                for (int i = 0; i < pirmaisMasivs.Length; i++) //izveido masivu
                {
                    Console.WriteLine("\nIevadiet masiva vertibu vai iziet");  //veic ievadi
                    ievade = Console.ReadLine();
                    if (ievade == "iziet")
                    {
                        break;
                    }
                    pirmaisMasivs[i] = ievade;

                    for (int j = 0; j < pirmaisMasivs.Length; j++)
                    {
                        Console.Write(pirmaisMasivs[j]);  //veic izvadi

                    }
                    Console.WriteLine();

                }
            }
        }

                //vertibas cilvekam ir jaievada kamer vins izvelas ka to vairs negrib
                //ievadam 1 vertibu un katras izvades beigaas izvadas viss masivs
                //parrakstam vertibas

                public void Stripinas()
                {
                    String[] stripinas = new string[4] { "-", "-", "-", "-" };

            for (int i = 0; i < stripinas.Length; i++)
            {
                Console.Write(stripinas[i]);
            }
            Console.WriteLine();
        }


            }
        }


