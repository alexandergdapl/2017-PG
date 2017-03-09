using System;

namespace marzec_szesc
{
    class Liczby
    {
        //private static int IloscLiczb;
        //public int[] PodaneLiczby = new int[IloscLiczb];
        //public int[] KwadratyLiczb = new int[IloscLiczb];


        public void LiczKwadratyLiczb()
        {
            Console.WriteLine("Podaj ilość liczb: ");

            try
            {
                int iloscLiczb = int.Parse(Console.ReadLine());
                
                Console.WriteLine("ilość liczb = {0}", iloscLiczb);

                Console.WriteLine("a teraz wpisz po kolei liczby zatwierdzając enterem: ");

                int[] podaneLiczby = new int[iloscLiczb];
                for (int i = 0; i < iloscLiczb; i++)
                {
                    podaneLiczby[i] = int.Parse(Console.ReadLine());
                }

                int[] kwadratyLiczb = new int[iloscLiczb];
                for (int i = 0; i < iloscLiczb; i++)
                {
                    Console.WriteLine(podaneLiczby[i]);
                }


                for (int i = 0; i < iloscLiczb; i++)
                {
                    kwadratyLiczb[i] = podaneLiczby[i] * podaneLiczby[i];
                }


                for (int i = 0; i < iloscLiczb; i++)
                {
                    Console.WriteLine("kwadrat liczby {0} wynosi {1}",
                                        podaneLiczby[i], kwadratyLiczb[i]);
                }

                int suma = 0;
                for (int i = 0; i < iloscLiczb; i++)
                {
                    suma += kwadratyLiczb[i];
                }

                Console.WriteLine("Suma kwadratów wynosi {0,4}", suma);
            }
            catch (Exception)
            {
                Console.WriteLine("Wprowadzono inny znak niż liczba lub nie wprowadzono znaku/liczby.");
            }
            
        }
    }
}

