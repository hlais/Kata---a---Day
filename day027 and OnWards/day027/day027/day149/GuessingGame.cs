using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class GuessingGame
    {
        private int number;
        private int lives;

        public GuessingGame(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (lives <= 0)
            {
                throw new Exception();
            }
           
                bool condition = (n == number);
                if (!condition)
                {
                    this.lives--;
                }
                return condition;
            }
         
            
        }
    }


