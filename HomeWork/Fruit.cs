using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Fruit
    {
        public int Temp;
        public string Name;
        public string Vitamins;
        public int count = 1;
        public Fruit(string name,string vitamins)
        {
            Temp = count;
            Name = name;
            Vitamins = vitamins;
            count++;

        }
    }
}
