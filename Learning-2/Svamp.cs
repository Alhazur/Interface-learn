using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_2
{
    class Svamp : IFarlig
    {
        public string Name { get; set; }

        public string Utsaende { get; set; }

        private int nivå;
        public int Nivå { get { return nivå; } set { nivå = value;  } }

        string beskrivning;
        public string Beskrivning { get { return beskrivning; } set { beskrivning = value; } }

        public void FarligIngo()
        {
            Console.WriteLine($"Farlig\n{Name} \nNivå: {nivå}\nBeskrivning: {beskrivning}");//nado zapisat dva raza imya
        }
    }
}
