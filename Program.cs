using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Health = 100;
        static int Shield = 100;
        static int Lives = 3;

        static void HUD()
        {
            Console.WriteLine(Health + " Health Points");
            Console.WriteLine(Shield + " Shield HitPoints");
            Console.WriteLine("");
            Console.WriteLine(Lives + " Lives Left");
            Console.WriteLine("----------------------------------------");
            if (Health >= 100) Console.WriteLine("Perfect Health");
            else if (Health >= 75) Console.WriteLine("Ok");
            else if (Health >= 50) Console.WriteLine("Hurt");
            else if (Health >= 25) Console.WriteLine("Badly Hurt");
        }
        static void Takedamage(int damage)
        {
            if (damage < 0) { damage = 0; Console.WriteLine(" damage = 0"); }
            if (Shield > 0)
            {
                if (Shield > damage)
                {
                    Shield = Shield - damage;
                }
                else { damage = damage - Shield; Health = Health - damage; Shield = 0; }

            }
            else
            {
                Health = Health - damage;
            }
            if (Health <= 0) { Heal(100); Regenerate(100); Lives -= 1; }


        }
        static void Heal(int heal)
        {
            if (heal < 0) { heal = 0; }
            Health = Health + heal;
            if (Health > 100) { Health = 100; }
        }
        static void Regenerate(int regen)
        {
            if (regen < 0) { regen = 0; }
            Shield = Shield + regen;
            if (Shield > 100) { Shield = 100; }
        }




        static void Main(string[] args)
        {


            while (Lives >= 0)
            {
                HUD();

                Console.ReadKey();



                Heal(10);



                Takedamage(60);





                Regenerate(10);





                HUD();



                Console.ReadKey();



                Heal(10);



                Takedamage(30);





                Regenerate(10);





                HUD();

                Console.ReadKey();

                Console.ReadKey();



                Heal(10);



                Takedamage(28);





                Regenerate(10);





                HUD();

                Console.ReadKey();
            }


        }
    }
}