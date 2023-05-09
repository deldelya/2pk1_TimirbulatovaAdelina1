using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Atom
    {
        public string Name1;
        public string Name2;
        public string Name3;
        public string Name4;
        public int countElectrons1;
        public int countElectrons2;
        public int countElectrons3;
        public int countElectrons4;
        public double mass1;
        public double mass2;
        public double mass3;
        public double mass4;
        public int valence1;
        public int valence2;
        public int valence3;
        public int valence4;

        public Atom() 
        {
            Name1 = "Helium";
            countElectrons1 = 2;
            mass1 = 4.002;
            valence1 = 0;
            Name2 = "Sulfur";
            countElectrons2 = 16;
            mass2 = 32.06;
            valence2 = 2;
            Name3 = "Radon";
            countElectrons3 = 86;
            mass3= 222;
            valence3 = 0;
            Name4 = "Radium";
            countElectrons4= 88;
            mass4 = 226;
            valence4= 2;

        }


        public void PrintInfo()
        {
            Console.WriteLine($"Наименование химического элемента: {Name1}\nКоличество электронов: {countElectrons1}\nМасса хим.Элемента: {mass1}\nВалентность хим. Элемента: {valence1}\n");
            Console.WriteLine("");
            Console.WriteLine($"Наименование химического элемента: {Name2}\nКоличество электронов: {countElectrons2}\nМасса хим.Элемента: {mass2}\nВалентность хим. Элемента: {valence2}\n");
            Console.WriteLine("");
            Console.WriteLine($"Наименование химического элемента: {Name3}\nКоличество электронов: {countElectrons3}\nМасса хим.Элемента: {mass3}\nВалентность хим. Элемента: {valence3}\n");
            Console.WriteLine("");
            Console.WriteLine($"Наименование химического элемента: {Name4}\nКоличество электронов: {countElectrons4}\nМасса хим.Элемента: {mass4}\nВалентность хим. Элемента: {valence4}\n");
        }
    }
}
