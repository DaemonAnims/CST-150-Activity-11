using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_11
{
    public class Dice
    {
        //Fields
        private int _sides;

        //Getter/Setter
        public int Sides 
        {
            get 
            {
                return _sides;
            }
            set
            {
                if (value < 4 || value > 20)
                    MessageBox.Show("Error! Side count cannot be less than 4 or more than 20!");
                else
                {
                    _sides = value;
                }
            }
        }

        //Constructor
        public Dice(int sides) => Sides = sides;

        //RollDie method
        public int RollDie()
        {
            //Initialize Random
            Random r = new Random();
            //Return next random with inclusive bottom bound of 1, exclusive top bound, so increase _sides by 1.
            return r.Next(1, _sides + 1);
        }
    }
}
