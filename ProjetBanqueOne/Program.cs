using System;

namespace ProjetBanqueOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte compteOne = new Compte();
            Compte compteTwo = new Compte(12345, "toto", 1000, -500);

            //compteTwo.Crediter(2000);
            //Console.WriteLine(compteTwo.ToString());
            //compteTwo.Debiter(5300);
            //Console.WriteLine(compteTwo.ToString());

            //Compte c1 = new Compte(12345, "toto", 1000, -500);
            //Compte c2 = new Compte(45657, "titi", 2000, -1000);

            //c1.Transferer(c2, 3300);
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c2.ToString());
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            if (c1.Superieur(c2))
                Console.WriteLine("superieur");
            else
                Console.WriteLine("inférieur");

        }
    }
}
