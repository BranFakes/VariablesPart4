﻿using System;
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
          

            Console.WriteLine("Press Any Key To Continue"); // Intructions

            Console.ReadKey(true); // key press to continue

            Console.WriteLine(""); //space between lines

            Console.WriteLine("TITLE:");
            Console.WriteLine("You're Gonna Die"); // Game name

            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("------HUD------"); // HUD

            Console.WriteLine(""); 
            Console.ReadKey(true); 

            float XP; 
            float XPGAINED; 

            string Name;
            string HPT;

            int BHP;
            int EXP; // Player EXP
            int HP; // Player HP
            int EHP; // Enemy HP


            Name = "Player Health Points";
            Console.WriteLine(Name);

            HP = 100;
            Console.WriteLine(HP);


            Console.WriteLine("");

            Console.WriteLine("EXP");


            EXP = 0;  
            Console.WriteLine(EXP);

           
            


        

           





            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("------Battle!------");

            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("Enemy Health Remaining");

            EHP = 100;
            Console.WriteLine(EHP);

            Console.WriteLine("");

            Name = "Enemy Attacks";
            Console.WriteLine(Name);

            Console.WriteLine("Damage Taken - 25");
            

            Name = "Health Points Remaining";
            Console.WriteLine(Name);

            HP = HP - 25; 
            Console.WriteLine(HP);


            Console.WriteLine("");
            Console.ReadKey(true);

            Name = "-Player Attacks"; 
            Console.WriteLine(Name);

            Name = "CRITICAL HIT 100 DMG"; // needs to be fixed
            Console.WriteLine(Name);

            Console.WriteLine("");

            Console.WriteLine("Enemy Health Remaining");
            EHP = 100 - 100;
            Console.WriteLine(EHP);

            Console.WriteLine("");
            Name = "Enemy Dies";
            Console.WriteLine(Name);

            Console.WriteLine("");
            Console.ReadKey(true);

      
            XP = 100.0f; 
            XPGAINED = 5.0f;

            Console.WriteLine("------Battle Ends-------");
            Console.WriteLine("");

            Console.ReadKey(true);

            Console.WriteLine("------Victory Music Plays-------");
            Console.WriteLine("");

            Console.ReadKey(true);

            Console.WriteLine("-EXP GAINED " + XP);
            Console.WriteLine("BONUS CRITICAL HIT EXP x" + XPGAINED);


            float BonusXP;
            float LostBonusXP;

            BonusXP = 100.0f * 5.0f;

            LostBonusXP = 500.0f / 500.0f - 1.0f;

            Console.WriteLine("Total EXP Gained " + BonusXP);



            Console.WriteLine("");

            Console.ReadKey(true);

            Console.WriteLine("------Boss Music Intensifies------");

            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("------OBJECTIVE: DEFEAT THE BOSS------");

            Console.ReadKey(true);
            Console.WriteLine("");

            Console.WriteLine("------Battle!------");

            Console.ReadKey(true);
            Console.WriteLine("");


            Name = "-Boss Attacks";
            Console.WriteLine(Name);

            HPT = "Heavy Damage Taken -50"; // needs to be fixed
            Console.WriteLine(HPT);

            Name = "Health Points Remaining";
            Console.WriteLine(Name);

            HP = HP - 50;
            Console.WriteLine(HP);


            Console.ReadKey(true);
            Console.WriteLine("");


            Name = "-Player Attacks";
            Console.WriteLine(Name);

            Name = "Attack Missed!";
            Console.WriteLine(Name);

            Name = "No Items Remaining";
            Console.WriteLine(Name);

            Console.WriteLine("");
            Console.ReadKey(true);


            Name = "-Boss Attacks";
            Console.WriteLine(Name);

            HPT = "Heavy Damage Taken -25"; // needs to be fixed
            Console.WriteLine(HPT);

            Name = "CRITICAL HIT";
            Console.WriteLine(Name);

            Name = "Health Points Remaining";
            Console.WriteLine(Name);

            HP = HP - 25;
            Console.WriteLine(HP);

            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("Total EXP Gained " + LostBonusXP);

            Console.WriteLine("");
            Console.ReadKey(true);
           

            Console.WriteLine("------Battle Ends------");

            Console.WriteLine("");
            Console.ReadKey(true);


            Console.WriteLine("------Sad Music------");

            Console.WriteLine("");
            Console.ReadKey(true);


            Console.WriteLine("      YOU DIED...     ");

            Console.WriteLine("");
            Console.ReadKey(true);


            Console.WriteLine("Hit the play button to try again.");

            Console.WriteLine("");
            Console.ReadKey(true);


            Console.WriteLine("Thanks for playing!");






















            Console.ReadKey(true); // wait for keypress before exiting
        }
    }
}