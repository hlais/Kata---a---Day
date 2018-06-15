using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class DeclareWinner
    {

        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            string currentAttacker = firstAttacker;
            string winner = "";

            while (true)
            {
                if (currentAttacker == fighter1.Name)
                {
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    Console.WriteLine($"{fighter1.Name} attacked {fighter2.Name}!" +
                        $" Taking damage of {fighter1.DamagePerAttack}, leaving {fighter2.Health} hp" );

                    if (fighter2.Health <= 0)
                    {
                        winner = fighter1.Name;

                        break;
                    }

                    currentAttacker = fighter2.Name;
                }
                else if (currentAttacker == fighter2.Name)
                {
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;

                    Console.WriteLine($"{fighter2.Name} attacked {fighter1.Name}!" +
                        $" Taking damage of {fighter2.DamagePerAttack}, leaving {fighter1.Health} hp");

                    if (fighter1.Health <= 0)
                    {
                        winner = fighter2.Name;
                        break;
                    }
                    currentAttacker = fighter1.Name;
                }

            }
            return winner;

         


        }
        public class Fighter
        {
            public string Name;
            public int Health, DamagePerAttack;
            public Fighter(string name, int health, int damagePerAttack)
            {
                this.Name = name;
                this.Health = health;
                this.DamagePerAttack = damagePerAttack;
            }
        }

    }
}

