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
            Console.WriteLine("You're Gonna Die");

            string Name;
            string HPT;
          
            int HP;

            Name = "Health Points Remaining";
            Console.WriteLine(Name);

            HP = 100; 



            Console.WriteLine(HP);

            




            Name = "Enemy Attacks";
            Console.WriteLine(Name);

            HPT = "Damage Taken -25";
            Console.WriteLine(HPT);

            Name = "Health Points Remaining";
            Console.WriteLine(Name);

            HP = HP - 25; 
            Console.WriteLine(HP); 






            Name = "Player Attacks"; 
            Console.WriteLine(Name);

            Name = "CRITICAL HIT";
            Console.WriteLine(Name);

            Name = "Enemy Dies";
            Console.WriteLine(Name);


            float XP; // kph
            float XPGAINED; // in kms
             // pointless due to 100.0f. it will be overwritten. "f" tells its a float. 100.0f = 100 float. 
            XP = 100.0f; // kph
            XPGAINED = 50.0f; // kms

            Console.WriteLine("EXP GAINED " + XP);
            Console.WriteLine("BONUS CRITICAL HIT POINTS " + XPGAINED);


            // ------------------ INTS vs. FLOATS------------------
            int intTest; // bad naming
            float floatTest; // bad naming
            float floatTest2;
            intTest = 10 / 3; // 3 ???
            floatTest = 10 / 3; // 3.333 ???
            floatTest2 = 10.0f / 3.0f; // 3.333
            Console.WriteLine(intTest);
            Console.WriteLine(floatTest);
            Console.WriteLine(floatTest2);



            Console.ReadKey(true); // wait for keypress before exiting
        }
    }
}