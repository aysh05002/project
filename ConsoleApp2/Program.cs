using System;

namespace classproject
    {
class program
    {
        static void Main(string[]args)
        {
            Random slump = new Random();

            int kort1 = slump.Next(1,11);
            int kort2 = slump.Next(1,11);
            int kort3 = slump.Next(1,11);
            int kort4 = slump.Next(1, 11);

            int[] minaKort = new int[5];
            int[] bankensKort = new int[5];

            for (int i = 0; i < 2; i++)
            {
                minaKort[i] = slump.Next(1,11);
                bankensKort[i] = slump.Next(1,11);  
            }


            Console.WriteLine("välj vad du vill göra");
            Console.WriteLine("1.spela 21:an");
            Console.WriteLine("2.Vissa senaste vinnare");
            Console.WriteLine("3.spelets regler");
            Console.WriteLine("4.Avsluta programmet");
            int nummer= int.Parse(Console.ReadLine());  
            switch (nummer)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2: 
                    Console.WriteLine("");
                    break;
               case 3:
                    Console.WriteLine("Du spelar mot en croupier (banken) och det gäller att få en hand som slår bankens hand. Om din poäng är högre än bankens så vinner du dubbla insatsen. Om du får exakt 21 på dina första två kort så får du Blackjack vilket ger 2.5 gånger     pengarna tillbaka. ");
                    break;
                case 4:

                    Console.WriteLine("Programmet avslutas");
                     break;
                   
            }

        }
    }
}
