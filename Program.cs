using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------HUD------");
            Console.WriteLine("You're Gonna Die");

            Console.WriteLine("");

            string Name;
            string HPT;
          
            int HP;

            Name = "Health Points";
            Console.WriteLine(Name);

            HP = 100;




            Console.WriteLine(HP);


            Console.WriteLine("");


            Console.WriteLine("------Battle!------");

            Name = "Enemy Attacks";
            Console.WriteLine(Name);

            HPT = "Damage Taken -25";
            Console.WriteLine(HPT);

            Name = "Health Points Remaining";
            Console.WriteLine(Name);

            HP = HP - 25; 
            Console.WriteLine(HP);


            Console.WriteLine("");



            Name = "Player Attacks"; 
            Console.WriteLine(Name);

            Name = "CRITICAL HIT";
            Console.WriteLine(Name);

            Name = "Enemy Dies";
            Console.WriteLine(Name);

            Console.WriteLine("");


            float XP; 
            float XPGAINED; 
      
            XP = 100.0f; 
            XPGAINED = 50.0f;

            Console.WriteLine("------Battle Ends-------");
            Console.WriteLine("");
            Console.WriteLine("------Victory Music Plays-------");
            Console.WriteLine("");

            Console.WriteLine("EXP GAINED " + XP);
            Console.WriteLine("BONUS CRITICAL HIT EXP " + XPGAINED);


            float BonusXP;

            BonusXP = 100.0f + 50.0f;

            Console.WriteLine("Total EXP Gained " + BonusXP);



            Console.WriteLine("");
            Console.WriteLine("----Boss Music Intensifies----");






    




            Console.ReadKey(true); // wait for keypress before exiting
        }
    }
}