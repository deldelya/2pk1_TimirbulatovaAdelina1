using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Atom
    {
        private string name;
        private static int countElectorns;
        private double mass;
        private int valence;
        public string Name { 
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Пустое имя хим. Элемента");
                }
                else
                {
                    name = value;
                }
            }
        
        }

        public int CountElectorns
        { get { return countElectorns; }
        set 
        {
                if (value > 0) 
                {

                }
        }
        }
        
    }
}
