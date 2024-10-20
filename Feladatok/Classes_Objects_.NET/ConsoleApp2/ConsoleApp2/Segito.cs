﻿namespace ConsoleApp2
{
    public static class Segito
    {
        public static double Atlag(List<int> szamok)
        {
            int osszeg = 0;
            foreach (int sz in szamok)
            {
                osszeg += sz;
            }
            if (szamok.Count == 0)
            {
                return 0;
            }
            return osszeg / szamok.Count;
        }

        public static int Szambekero()
        {
            int eredmeny;
            while (!int.TryParse(Console.ReadLine(), out eredmeny))
            {
                Console.WriteLine("Nem megfelelő szám");
            }
            return eredmeny;
        }

      public static int Szambekero(int limit)
        {
            int eredmenyLimites = 0;
            do
            {
                if(eredmenyLimites < 4){
                    eredmenyLimites = Szambekero();
                }
                else{
                    eredmenyLimites = 4;
                }
                
            } while (eredmenyLimites > limit);
            return eredmenyLimites;
        }


    }
}

 /* public static int Szambekero(int limit)
        {
            int eredmenyLimites = 0;
            do
            {
                if(eredmenyLimites < 4){
                    eredmenyLimites = Szambekero();
                }
                else{
                    eredmenyLimites = 4;
                }
                
            } while (eredmenyLimites > limit);
            return eredmenyLimites;
        }
 */