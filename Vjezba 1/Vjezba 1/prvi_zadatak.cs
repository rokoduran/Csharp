using System;
using System.Collections.Generic;

namespace Vjezba_1
{
   /* class prvi_zadatak
    {
        static void Main(string[] args)
        {
            String broj_1 = Console.ReadLine();
            String broj_2 = Console.ReadLine();

            int rezultat = 0;

            try
            {
                rezultat=Convert.ToInt32(broj_1) / Convert.ToInt32(broj_2);
            }

            catch (Exception e) {
                if (e is DivideByZeroException)
                    Console.WriteLine("Djeljenje {0} s nulom.", broj_1);

                else Console.WriteLine("Neki od argumenata nisu bili brojevi.");
            }

           Console.WriteLine(rezultat.ToString());
           Console.WriteLine(rezultat.ToString("C"));
           Console.WriteLine(rezultat.ToString("E"));
           Console.WriteLine(rezultat.ToString("F"));
           Console.WriteLine(rezultat.ToString("G"));
           Console.WriteLine(rezultat.ToString("N"));
           Console.WriteLine(rezultat.ToString("X"));
        }
    }*/

    /*class drugi_zadatak
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            long b = long.MaxValue;

            try
            {
                a = ((int)b + a);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
            Console.WriteLine(a.ToString());
        }
    }
    */
    class treci_zadatak
    {
        public enum Racun
        {
            stednja = 1, Tekući_Racun = 2, ziro_Racun = 3
        }

        static void Meni(List<BankAccount> accounts )
        {
            accounts = new List<BankAccount>();
            int choice=0;
            while (true)
            {
                Console.WriteLine("Odaberite opciju. \n");
                Console.WriteLine("1. Stvaranje novog racuna \n ");
                Console.WriteLine("2. Ispis svih racuna \n");
                Console.WriteLine("3. Izlaz \n");
                Console.WriteLine("\n");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    int choice2 = 0;
                    while (!Racun.IsDefined(typeof(Racun), choice2))
                    {
                        Console.WriteLine("Odaberite vrstu racuna");
                        Console.WriteLine("1. stednja ");
                        Console.WriteLine("2. Tekući Racun ");
                        Console.WriteLine("3. ziro racun ");
                        Console.WriteLine("\n");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                    }
                    accounts.Add(new BankAccount(choice2));
                }
                else if(choice == 2)
                {
                    foreach (BankAccount account in accounts) account.print();
                }
                else if(choice == 3)
                {
                    return;
                }
            }
        }

        class BankAccount {

            private String Broj_Racuna;
            private int Iznos_Racuna;
            private Racun Vrsta_Racuna;

            public BankAccount() {
                Broj_Racuna = new Random().Next(0, int.MaxValue).ToString();
                Iznos_Racuna = new Random().Next(0, int.MaxValue);
                Vrsta_Racuna =(Racun) new Random().Next(1,3);

            }
            public BankAccount(int vrsta)
            {
                Broj_Racuna = new Random().Next(int.MinValue, int.MaxValue).ToString();
                Iznos_Racuna = new Random().Next(int.MinValue, int.MaxValue);
                Vrsta_Racuna = (Racun) vrsta;

            }
            public void print()
            {
                Console.WriteLine(Broj_Racuna);
                Console.WriteLine(Iznos_Racuna.ToString());
                switch ((int)Vrsta_Racuna) {
                    case 1:
                        Console.WriteLine("stednja ");
                            break;
                    case 2:
                        Console.WriteLine("Tekući racun ");
                        break;
                    case 3:
                        Console.WriteLine("ziro racun ");
                        break;
                }
                Console.WriteLine("\n");
            }
          }

        static void Main(string[] args) {
            List<BankAccount> accounts = new List<BankAccount>();
            for (int i = 0; i < 5; i++)
                accounts.Add(new BankAccount());
            Meni( accounts);
            Console.WriteLine(accounts.Count);
        }
    }
}